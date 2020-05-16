using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace StockExample.Brokers
{
    public static class BrokersConfiguration
    {
        public static readonly IReadOnlyDictionary<string, Guid> Ids =
            new ReadOnlyDictionary<string, Guid>
            (
                new Dictionary<string, Guid>
                {
                    { nameof(BlueBroker),  new Guid("082ca906-6edb-4f22-a720-5c456bcedc64") },
                    { nameof(RedBroker),  new Guid("1d9bf2ca-2a9d-486f-a83f-63d6c828c083") },
                    { nameof(GreenBroker),  new Guid("1612356b-9f34-478b-a2b6-61752434bab4") }
                }
            );
    }
}
