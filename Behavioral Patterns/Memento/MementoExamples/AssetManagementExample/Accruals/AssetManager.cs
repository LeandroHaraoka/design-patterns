using AssetManagementExample.Assets;
using AssetManagementExample.Repositories;
using Assets;
using System;
using System.Collections.Generic;
using System.Linq;
using static AssetManagementExample.Accruals.FinancialOperations;

namespace AssetManagementExample.Accruals
{
    public interface IAssetManager
    {
        void UpdateStateUntil(DateTime finalDate);
    }

    public class AssetManager : IAssetManager
    {
        private readonly IRepository<Movement> _movementsRepository;
        private IEnumerable<Movement> _movements;

        private readonly AssetContract _contract;
        private readonly CareTaker _careTaker;

        public AssetManager(CareTaker careTaker, Asset asset, IRepository<Movement> movementsRepository)
        {
            _movementsRepository = movementsRepository;
            _contract = asset._contract;
            _careTaker = careTaker;
        }

        public void UpdateStateUntil(DateTime finalDate)
        {
            var currentState = _careTaker.GetAssetCurrentState();

            var hasMovements = UpdateMovements(currentState);
            var hasState = currentState._date != DateTime.MinValue;

            if (!hasState && !hasMovements)
                return;

            var currentDate = hasState ? currentState._date.AddDays(1) : _movements.First().TradeDate;

            while (currentDate <= finalDate)
            {
                UpdateState(currentDate);
                currentDate = currentDate.AddDays(1);
            }
        }

        private void UpdateState(DateTime currentDate)
        {
            var movementsAmount = _movements.Where(m => m.TradeDate == currentDate).Sum(x => x.Amount);

            var assetNewValue = Accrual(
                currentDate, 
                movementsAmount + _careTaker.GetAssetCurrentState()._currentValue, 
                _contract.IndexRate);

            _careTaker.ChangeAssetState(new AssetState(currentDate, assetNewValue));
        }

        private bool UpdateMovements(AssetState currentState)
        {
            _movements = _movementsRepository.Find(x => x.TradeDate > currentState._date);
            return _movements.Any();
        }
    }
}
