using AssetManagementExample.Movements;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AssetManagementExample.Repositories
{
    public interface IRepository<T>
    {
        void Add(T item);
        IEnumerable<T> Find(Func<T, bool> filter);
    }

    public class MovementRepository : IRepository<Movement>
    {
        private readonly List<Movement> _movements = new List<Movement>();

        public void Add(Movement item) => _movements.Add(item);

        public IEnumerable<Movement> Find(Func<Movement, bool> filter) => _movements.Where(filter);
    }
}
