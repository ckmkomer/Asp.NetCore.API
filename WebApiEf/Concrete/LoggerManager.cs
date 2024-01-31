using NLog;
using WebApiEf.Contracts;

namespace WebApiEf.Concrete
{
    public class LoggerManager : ILoggerService
    {
        private static NLog.ILogger _logger =LogManager.GetCurrentClassLogger();
        public void LogDebuger(string message)
        {
           _logger.Debug(message);
        }

        public void LogError(string message)
        {
            _logger?.Error(message);
        }

        public void LogInfo(string message)
        {
            _logger.Info(message);
        }

        public void LogWarning(string message)
        {
            _logger.Warn(message);
        }
    }
}
