using AssetManagementExample.Assets;
using AssetManagementExample.Movements;
using AssetManagementExample.Repositories;
using System;
using System.Linq;
using static AssetManagementExample.Accruals.MathOperations;
using static AssetManagementExample.Curves;

namespace AssetManagementExample.Accruals
{
    public class Accrual
    {
        private readonly IRepository<Movement> _movementsRepository;

        public Accrual(IRepository<Movement> movementsRepository)
        {
            _movementsRepository = movementsRepository;
        }

        public void ExecuteUntil(DateTime finalDate, Asset asset, CareTaker careTaker)
        {
            var lastSnapshotDate = asset._state._date;

            var movements = _movementsRepository
                .Find(x => x.TradeDate > lastSnapshotDate).OrderBy(x => x.TradeDate);
            
            if (lastSnapshotDate == DateTime.MinValue && !movements.Any())
                return;

            var currentDate = lastSnapshotDate == DateTime.MinValue
                ? movements.First().TradeDate
                : lastSnapshotDate.AddDays(1);

            var currentState = asset._state;

            while (currentDate <= finalDate)
            {
                var amountToAccrual = asset._state._currentValue
                    + movements.Where(m => m.TradeDate == currentDate).Sum(x => x.Amount);

                var DIValue = DICurve[currentDate];

                var currentValue = ApplyTax(amountToAccrual, asset._contract.IndexRate * DIValue);

                asset._state = new AssetState(currentDate, DIValue, currentValue);
                careTaker.Save();

                currentDate = currentDate.AddDays(1);
            }
        }
    }
}
