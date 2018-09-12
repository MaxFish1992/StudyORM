using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.AsyncUtil
{
    /// <summary>
    /// 异步编程接口
    /// </summary>
    public partial interface IAsyncUtil
    {
        /// <summary>
        /// 开启一个异步方法
        /// </summary>
        /// <param name="action"></param>
        void TaskOne(Action action);
        /// <summary>
        /// 开启一个异步方法，并且等待方法完成
        /// </summary>
        /// <param name="action"></param>
        void TaskOneWait(Action action);
    }
}
