using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.DBUtil
{
    public static class DBHelper<T> where T : class, new()
    {
        //private static DBUtilManager<T> DBUtilManager { get; set; } = new DBUtilManager<T>();

        public static int Add(string sql, T t)
        {
            DBUtilManager<T> dbUtilManager = new DBUtilManager<T>();
            return dbUtilManager.Add(sql, t);
        }
    }
}
