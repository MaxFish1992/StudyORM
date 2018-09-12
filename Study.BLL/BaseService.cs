using Study.IBLL;
using Study.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.BLL
{
    public abstract partial class BaseService<T>: IBaseService<T> where T : class, new()
    {
        public BaseService()
        {
            SetDal();
        }

        public IBaseDAL<T> Dal;
        public abstract void SetDal();
        public int Add(string sql,T t)
        {
            return Dal.Add(sql,t);
        }
        public int Delete(string sql, T t)
        {
            return Dal.Delete(sql, t);
        }
        public int Update(string sql, T t)
        {
            return Dal.Update(sql, t);
        }
        public IList<T> GetModels(string sql, T t)
        {
            return Dal.GetModels(sql, t);
        }
    }
}
