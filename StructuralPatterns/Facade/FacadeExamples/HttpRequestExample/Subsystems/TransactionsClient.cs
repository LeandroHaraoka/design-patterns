using System;
using System.Net.Http;

namespace HttpRequestExample.Subsystems
{
    public class TransactionsClient
    {
        public HttpResponseMessage Send(HttpRequestMessage requestMessage)
        {
            // Instructions to define retry policies.
            Console.WriteLine("Sending request to the specified destination.");
            return new HttpResponseMessage();
        }
    }
}
