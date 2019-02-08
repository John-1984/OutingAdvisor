using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public static class Logger
    {
        private static readonly log4net.ILog logger;
        static Logger()
        {
            log4net.Config.XmlConfigurator.Configure();
            logger = log4net.LogManager.GetLogger("logger");
        }

        public static void Log(string message)
        {
            logger.Info(message);
        }
    }
}
