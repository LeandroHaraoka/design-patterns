using LoggerAdapterExample.CommandCenter;
using LoggerAdapterExample.Logs;
using System;
using System.Reflection;

namespace LoggerAdapterExample
{
    public class LoggerAdapter : ILogger
    {
        private readonly CustomLogger _customLogger;
        private readonly string _applicationName = Assembly.GetExecutingAssembly().GetName().Name;

        public LoggerAdapter(CustomLogger commandCenterLogger)
        {
            _customLogger = commandCenterLogger;
        }

        public void LogError(Exception exception) => 
            _customLogger.NotifyError(exception.Message, _applicationName);

        public void LogInfo(string message) => 
            _customLogger.NotifyInfo(message, _applicationName);
    }
}
