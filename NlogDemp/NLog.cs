using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace NlogDemp
{
    /// <summary>
    /// Nlog class to define different logger object to debug program
    /// </summary>
    public class NLog
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public static void DebugInfo(string msg)
        {
            logger.Debug(msg);
        }
        public static void InfoLevel(string msg)
        {
            logger.Info(msg);
        }
        public static void ErrorInfo(string msg)
        {
            logger.Error(msg);
        }
        public static void WarnInfo(string msg)
        {
            logger.Warn(msg);
        }
        public static void SuccessInfo(string msg)
        {
            logger.Info(msg);
        }
    }
}
