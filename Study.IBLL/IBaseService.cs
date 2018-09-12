using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.IBLL
{
    public partial interface IBaseService<T> where T : class, new()
    {
        int Add(string sql, T t);
        int Delete(string sql, T t);
        int Update(string sql, T t);
        IList<T> GetModels(string sql, T t);
    }
}
