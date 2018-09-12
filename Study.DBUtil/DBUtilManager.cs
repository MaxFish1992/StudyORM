using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.DBUtil
{
    public partial class DBUtilManager<T> : IDBUtil<T> where T : class, new()
    {
        public IDbConnection Connection { get; set; } = new SqlConnection(ConfigurationManager.AppSettings["StudyDB"].ToString());

        public int Add(string sql, T t)
        {
            try
            {
                return Connection.Execute(sql, t);
            }
            catch (Exception ex)
            {
                return 0;
            }
            
        }

        public int Delete(string sql, T t)
        {
            try
            {
                return Connection.Execute(sql, t);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public IList<T> GetModels(string sql, T t)
        {
            try
            {
                IList<T> results = new List<T>();
                results = Connection.Query<T>(sql, t) as IList<T>;
                return results;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int Update(string sql, T t)
        {
            try
            {
                return Connection.Execute(sql, t);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
