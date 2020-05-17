using AssetManagementExample.Movements;
using System;
using System.Collections.Generic;

namespace AssetManagementExample.Assets
{
    public class Asset
    {
        public AssetState _state;
        public Contract _contract;

        public Asset() => _state = new AssetState();

        public IMemento Save() =>  new AssetMemento(_state);

        public void Restore(IMemento memento) => _state = memento.GetState();
    }

    public interface IMemento
    {
        AssetState GetState();
        DateTime GetDate();
    }

    class AssetMemento : IMemento
    {
        private AssetState _state;

        public AssetMemento(AssetState state) => _state = state;

        public AssetState GetState() => _state;

        public DateTime GetDate() => _state._date;
    }

    public class AssetState
    {
        public DateTime _date;
        public decimal _rate;
        public decimal _currentValue;

        public AssetState()
        {
        }

        public AssetState(DateTime date, decimal rate, decimal currentValue)
        {
            _date = date;
            _rate = rate;
            _currentValue = currentValue;
        }
    }
}
