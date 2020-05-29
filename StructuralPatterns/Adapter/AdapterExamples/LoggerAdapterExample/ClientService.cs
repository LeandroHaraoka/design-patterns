using LoggerAdapterExample.Logs;
using System;

namespace LoggerAdapterExample
{
    public class ClientService
    {
        private readonly ILogger _logger;
        public ClientService(ILogger logger)
        {
            _logger = logger;
        }

        public void SomeServiceAction()
        {
            try
            {
                _logger.LogInfo($"Executing {nameof(SomeServiceAction)} method.");
                throw new ArgumentException(
                    $"This is a custom error message sent while executing {nameof(SomeServiceAction)} method.");
            }
            catch (Exception exception)
            {
                _logger.LogError(exception);
            }
        }
    }
}
