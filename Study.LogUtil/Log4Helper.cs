using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace Study.LogUtil
{
    public class Log4Helper
    {
        private static Type type;
        private static ILog m_log = null;
        private static object lockHelper = new object();
        private static log4net.ILog Log
        {
            get
            {
                if (null == m_log)
                {
                    lock (lockHelper)
                    {
                        if (null == m_log && System.AppDomain.CurrentDomain.BaseDirectory != null)
                        {
                            XmlConfigurator.Configure(new System.IO.FileInfo(System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "log4net.config")));
                            m_log = LogManager.GetLogger(type);
                        }
                    }
                }
                return m_log;
            }
        }
        //private static Log4Manager<T> Log4Manager;
        public static void Error(Type t, string message)
        {
            type = t;
            Log.Error(message);
        }
        public static void Debug(Type t, string message)
        {
            type = t;
            Log.Debug(message);
        }
        public static void Warn(Type t, string message)
        {
            type = t;
            Log.Warn(message);
        }
        public static void Info(Type t, string message)
        {
            type = t;
            Log.Info(message);
        }
        public static void Fatal(Type t, string message)
        {
            type = t;
            Log.Fatal(message);
        }

        public static void Error(Type t, string message,Exception ex)
        {
            type = t;
            Log.Error("=============================================\r\n"+message, ex);
        }
        public static void Debug(Type t, string message, Exception ex)
        {
            type = t;
            Log.Debug(message, ex);
        }
        public static void Warn(Type t, string message, Exception ex)
        {
            type = t;
            Log.Warn(message, ex);
        }
        public static void Info(Type t, string message, Exception ex)
        {
            type = t;
            Log.Info(message, ex);
        }
        public static void Fatal(Type t, string message, Exception ex)
        {
            type = t;
            Log.Fatal(message, ex);
        }
    }
}
