using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Infrastructure
{
    public class DataContext
    {
        private readonly string _connectstring = string.Empty;

        public DataContext(string connectionString)
        {
            _connectstring = connectionString;
        }

        public SqlSugar.SqlSugarClient Client()
        {
            return new SqlSugar.SqlSugarClient(_connectstring);
        }

    }
}
