using AssetManagementExample.Repositories;
using System;

namespace AssetManagementExample.Assets
{
    public class CareTaker
    {
        private readonly Asset _asset;
        private readonly IMementoRepository _mementoRepository;

        public CareTaker(Asset asset, IMementoRepository mementoRepository)
        {
            _asset = asset;
            _mementoRepository = mementoRepository;
        }

        public AssetState GetAssetCurrentState() => _asset._state;

        public AssetState ChangeAssetState(AssetState newState)
        {
            _asset._state = newState;
            _mementoRepository.Add(_asset.Save());
            return newState;
        }

        public void Restore(DateTime date)
        {
            _mementoRepository.RemoveSince(date);
            _asset.Restore(_mementoRepository.FindLast());
        }
    }
}
