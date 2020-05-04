namespace LazyLoadingExample.Logs
{
    public class Logger
    {
        private static Logger _logger;

        private Logger() { }

        public static Logger GetInstance()
        {
            if (_logger is null)
                _logger = new Logger();
            
            return _logger;
        }
    }
}
