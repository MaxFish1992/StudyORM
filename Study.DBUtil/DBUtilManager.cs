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

        public int Update(string sql, T t)
        {
            throw new NotImplementedException();
        }
    }
    public partial class DBUtilManager<T>
    {
        public void SayHellow()
        {
            Console.WriteLine("SayHellow!");
        }
    }
}
