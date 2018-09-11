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
            throw new NotImplementedException();
        }

        public int Delete(string sql, T t)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetModels(string sql, T t)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public int Update(string sql, T t)
        {
            throw new NotImplementedException();
        }
    }
}
