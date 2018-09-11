using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.DBUtil
{
    public partial interface IDBUtil<T> where T : class, new()
    {
        /// <summary>
        /// 数据库链接对象
        /// </summary>
        IDbConnection Connection { get; set; }
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="t">实体对象</param>
        /// <returns>受影响行数</returns>
        int Add(string sql, T t);
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="t">实体对象</param>
        /// <returns>受影响行数</returns>
        int Delete(string sql, T t);
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="t">实体对象</param>
        /// <returns>受影响行数</returns>
        int Update(string sql, T t);
        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="t">实体对象</param>
        /// <returns>受影响行数</returns>
        IList<T> GetModels(string sql, T t);
    }
}
