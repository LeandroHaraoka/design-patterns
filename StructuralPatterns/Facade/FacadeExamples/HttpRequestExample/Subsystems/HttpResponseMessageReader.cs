using System;
using System.Net.Http;

namespace HttpRequestExample.Subsystems
{
    public class HttpResponseMessageReader
    {
        public T Read<T>(HttpResponseMessage responseMessage) where T : new()
        {
            // Instructions to deserialize the http response message to a T
            Console.WriteLine("Deserializing Http Response Message.");
            return new T();
        }
    }
}
