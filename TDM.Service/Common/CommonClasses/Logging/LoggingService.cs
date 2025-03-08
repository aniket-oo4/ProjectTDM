using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace TDM.Service.Common.CommonClasses.Logging
{
    public class LoggingService
    {
        private readonly IEnumerable<ILogger> _loggers;

        public LoggingService(IEnumerable<ILogger> loggers)
        {
            _loggers = loggers;
        }
        public void UpdateErrorLog(string message, Exception exception = null)
        {
            foreach (var logger in _loggers)
            {
                //logger.LogError(message, exception);
            }
        }

        //public void LogInfo(string message)
        //{
        //    foreach (var logger in _loggers)
        //    {
        //        logger.LogInfo(message);
        //    }
        //}

        //public void LogWarning(string message)
        //{
        //    foreach (var logger in _loggers)
        //    {
        //        logger.LogWarning(message);
        //    }
        //}

    }

}
