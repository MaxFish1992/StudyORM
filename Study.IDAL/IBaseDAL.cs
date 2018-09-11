using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.IDAL
{
    public partial interface IBaseDAL<T> where T : class, new()
    {
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
        /// <summary>
        /// 一个业务中有可能涉及到对多张表的操作,那么可以将操作的数据,打上相应的标记,最后调用该方法,将数据一次性提交到数据库中,避免了多次链接数据库。
        /// </summary>
        bool SaveChanges();
    }
}
