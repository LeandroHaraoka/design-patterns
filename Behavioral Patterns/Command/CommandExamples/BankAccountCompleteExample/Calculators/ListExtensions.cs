using System.Collections.Generic;

namespace CalculatorExample.Calculators
{
    public static class ListExtensions
    {
        public static List<T> RemoveFrom<T>(this List<T> collection, int index)
        {
            if (collection.Count <= index + 1)
                return collection;

            var firstRemovedIndex = index + 1;
            var elementsToRemove = collection.Count - index - 1;

            collection.RemoveRange(firstRemovedIndex, elementsToRemove);

            return collection;
        }
    }
}
