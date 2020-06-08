using System;

namespace HttpRequestExample.Subsystems
{
    public class TransactionStatus
    {
        public Guid TransactionId { get; set; }
        public bool Status { get; set; }
    }
}
