using LoggerAdapterExample.CommandCenter;
using LoggerAdapterExample.Logs;
using System;
using System.Reflection;

namespace LoggerAdapterExample
{
    public class LoggerAdapter : ILogger
    {
        private readonly CommandCenterLogger _commandCenterLogger;
        private readonly LogLibrary _logLibrary;

        public LoggerAdapter(LogLibrary logLibrary, CommandCenterLogger commandCenterLogger)
        {
            _commandCenterLogger = commandCenterLogger;
            _logLibrary = logLibrary;
        }

        public void LogError(Exception exception)
        {
            _logLibrary.LogError(exception);
            _commandCenterLogger.EmitAlert(exception.Message, Assembly.GetExecutingAssembly().GetName().Name);
        }

        public void LogInfo(string message) => _logLibrary.LogInfo(message);
    }
}
