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

        public void Save()
        {
            _mementoRepository.Add(_asset.Save());
        }

        public void Restore(DateTime date)
        {
            _mementoRepository.RemoveSince(date);
            _asset.Restore(_mementoRepository.FindLast());
        }
    }
}
