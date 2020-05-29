using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerAdapterExample.Logs
{
    public interface ILogger
    {
        void LogInfo(string message);
        void LogError(Exception exception);
    }
}
