using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DLWebAPI
{
    public class MsSqlConnection
    {
        public string ConnectionString { get; set; }

        public MsSqlConnection(string connectionString)
        {
            this.ConnectionString = connectionString;
        }
        
        private SqlConnection GetMsSqlConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        
    }
}
