using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.DBUtil
{
    public static class DBHelper<T> where T : class, new()
    {
        public static int Add(string sql, T t)
        {
            var task = Task.Factory.StartNew(() => {
                DBUtilManager<T> dbUtilManager = new DBUtilManager<T>();
                return dbUtilManager.Add(sql, t);
            });
            return task.Result;
        }
        public static int Delete(string sql, T t)
        {
            var task = Task.Factory.StartNew(() => {
                DBUtilManager<T> dbUtilManager = new DBUtilManager<T>();
                return dbUtilManager.Delete(sql, t);
            });
            return task.Result;
        }
        public static int Update(string sql, T t)
        {
            var task = Task.Factory.StartNew(() => {
                DBUtilManager<T> dbUtilManager = new DBUtilManager<T>();
                return dbUtilManager.Update(sql, t);
            });
            return task.Result;
        }
        public static IList<T> GetModels(string sql, T t)
        {
            var task = Task.Factory.StartNew(() => {
                DBUtilManager<T> dbUtilManager = new DBUtilManager<T>();
                return dbUtilManager.GetModels(sql, t);
            });
            return task.Result;
        }
    }
}
