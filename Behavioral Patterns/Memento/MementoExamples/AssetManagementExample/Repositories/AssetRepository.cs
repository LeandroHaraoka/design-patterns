using AssetManagementExample.Assets;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AssetManagementExample.Repositories
{
    public interface IMementoRepository
    {
        void Add(IAssetMemento memento);
        void RemoveSince(DateTime date);
        IAssetMemento FindLast();
    }

    public class AssetRepository: IMementoRepository
    {
        private readonly Dictionary<DateTime, IAssetMemento> _mementos = new Dictionary<DateTime, IAssetMemento>();

        public void Add(IAssetMemento memento) => _mementos[memento.GetDate()] = memento;

        public void RemoveSince(DateTime date)
        {
            var keys = _mementos.Where(x => x.Key >= date).Select(x => x.Key).OrderBy(x => x.Date);

            foreach (var key in keys)
            {
                _mementos.Remove(key);
            }
        }

        public IAssetMemento FindLast() => _mementos.OrderBy(x => x.Key).LastOrDefault().Value;
    }
}
