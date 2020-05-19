using System;

namespace AssetManagementExample.Assets
{
    public class Asset
    {
        public AssetContract _contract;
        public AssetState _state = new AssetState();

        public IAssetMemento Save() =>  new AssetMemento(_state);

        public void Restore(IAssetMemento memento) => _state = memento.GetState();
    }

    public class AssetContract
    {
        public decimal IndexRate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime SettlementDate { get; set; }
    }

    public class AssetState
    {
        public DateTime _date;
        public decimal _currentValue;

        public AssetState()
        {
        }

        public AssetState(DateTime date, decimal currentValue)
        {
            _date = date;
            _currentValue = currentValue;
        }
    }
}
