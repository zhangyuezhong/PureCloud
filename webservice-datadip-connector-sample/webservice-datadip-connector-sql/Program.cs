using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using webservice_datadip_connector_sql.Services;

namespace webservice_datadip_connector_sql
{
    class Program
    {
        static void Main(string[] args)
        {
            string port = "8889";
            Console.WriteLine("Listening on port: " + port);
            string connectionString = ConfigurationManager.ConnectionStrings["TEST_DATABASE"].ToString();
            Console.WriteLine("ConnectionString: " + connectionString);
            SQLWebServicesImplementation DemoServices = new SQLWebServicesImplementation(connectionString);
            WebServiceHost _serviceHost = new WebServiceHost(DemoServices, new Uri("http://127.0.0.1:" + port));
            _serviceHost.Open();
            Console.ReadKey();
            _serviceHost.Close();
        }
    }
}
