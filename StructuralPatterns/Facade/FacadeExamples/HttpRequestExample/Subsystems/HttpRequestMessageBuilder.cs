using System;
using System.Net.Http;

namespace HttpRequestExample.Subsystems
{
    public class HttpRequestMessageBuilder
    {
        private readonly HttpRequestMessage _httpRequestMessage = new HttpRequestMessage();

        // Some other methods to build a http request message.

        public HttpRequestMessage Build()
        {
            Console.WriteLine("Building an Http Request Message.");
            return _httpRequestMessage;
        }
    }
}
