using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.DBUtil
{
    public static class DBHelper<T> where T : class, new()
    {
        private static DBUtilManager<T> DBUtilManager { get; } = new DBUtilManager<T>();
    }
}
