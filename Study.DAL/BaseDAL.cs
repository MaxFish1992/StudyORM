using Study.DBUtil;
using Study.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.DAL
{
    public partial class BaseDAL<T> : IBaseDAL<T> where T : class, new()
    {
        public int Add(string sql, T t)
        {
            return DBHelper<T>.Add(sql, t);
        }

        public int Delete(string sql, T t)
        {
            return DBHelper<T>.Delete(sql, t);
        }

        public IList<T> GetModels(string sql, T t)
        {
            return DBHelper<T>.GetModels(sql, t);
        }

        public bool SaveChanges()
        {
            return false;
        }

        public int Update(string sql, T t)
        {
            return DBHelper<T>.Update(sql, t);
        }
    }
}
