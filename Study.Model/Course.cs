using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Model
{
    /// <summary>
    /// 说明：课程实体对象
    /// 作者：huangwei
    /// 时间：2018-9-10
    /// </summary>
    public class Course
    {
        /// <summary>
        /// 全球唯一标识
        /// </summary>
        public string Guid { get; set; }
        /// <summary>
        /// 课程名称
        /// </summary>
        public string CourseName { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTime { get; set; }
    }
}
