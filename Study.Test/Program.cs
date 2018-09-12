using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 0;
                int b = 1 / a;
            }
            catch (Exception ex)
            {
                LogUtil.Log4Helper.Error(typeof(Program), ex.Message,ex);
            }

            //LogUtil.Log4Helper.Debug(typeof(Program),"这是一个Debug日志" + 2);
            //LogUtil.Log4Helper.Info(typeof(Program), "这是一个Info日志");
            //LogUtil.Log4Helper.Warn(typeof(Program), "这是一个Warn日志");
            //LogUtil.Log4Helper.Error(typeof(Program), "这是一个Error日志");
            //string temp1 = "helloworld";
            //LogUtil.Log4Helper.Fatal(typeof(Program), temp1);

        }
    }
}
