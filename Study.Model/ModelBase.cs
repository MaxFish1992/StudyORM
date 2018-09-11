using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Model
{
    public abstract class ModelBase
    {
        /// <summary>
        /// 全球唯一标识,所有model继承该类
        /// </summary>
        public string Guid { get; set; }
    }
}
