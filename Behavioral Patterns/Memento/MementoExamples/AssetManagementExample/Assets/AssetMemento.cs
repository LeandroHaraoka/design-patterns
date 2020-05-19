using System;

namespace AssetManagementExample.Assets
{
    public interface IAssetMemento
    {
        AssetState GetState();
        DateTime GetDate();
    }

    class AssetMemento : IAssetMemento
    {
        private AssetState _state;

        public AssetMemento(AssetState state) => _state = state;

        public AssetState GetState() => _state;

        public DateTime GetDate() => _state._date;
    }
}
