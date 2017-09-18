using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webservice_datadip_connector_sql.DataAccess
{
    public class DataSource
    {
        public DataSource()
        {

        }
        public DataSource(String connectionString)
        {
            this.ConnectionString = connectionString;

        }
        private String _ConnectionString;

        public String ConnectionString
        {
            get { return _ConnectionString; }
            set { _ConnectionString = value; }
        }

        public SqlConnection getSqlConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
