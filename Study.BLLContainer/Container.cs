using Autofac;
using Study.BLL;
using Study.IBLL;
using Study.LogUtil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.BLLContainer
{
    public class Container
    {
        /// <summary>
        /// IOC 容器
        /// </summary>
        public static IContainer container = null;

        /// <summary>
        /// 获取 IDal 的实例化对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Resolve<T>()
        {
            try
            {
                if (container == null)
                {
                    Initialise();
                }
            }
            catch (System.Exception ex)
            {
                Log4Helper.Error(typeof(Container), "IOC实例化出错!" + ex.Message, ex);
            }
            return container.Resolve<T>();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public static void Initialise()
        {
            var builder = new ContainerBuilder();
            //格式：builder.RegisterType<xxxx>().As<Ixxxx>().InstancePerLifetimeScope();
            builder.RegisterType<CourseService>().As<ICourseService>().InstancePerLifetimeScope();
            container = builder.Build();
        }
    }
}
