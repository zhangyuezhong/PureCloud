using inin.Bridge.WebServices.Datadip.Lib;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webservice_datadip_connector_sql.DataAccess.Repositories.Impl
{
    public class CaseRepositoryImpl : CaseRepository
    {
        private DataSource _DataSource;

        public CaseRepositoryImpl(DataSource _DataSource)
        {
            this._DataSource = _DataSource;
        }
        public ResponseCase GetMostRecentOpenCaseByContactId(ContactIdRequest cidr)
        {
            ResponseCase responseCase = new ResponseCase();
            responseCase.Case = new Case();
            try
            {
                using (SqlConnection con = _DataSource.getSqlConnection())
                {
                    con.Open();
                    string sql = "SELECT * FROM Cases where ContactId=@ContactId";
                    using (SqlCommand command = new SqlCommand(sql, con))
                    {
                        command.Parameters.Add(new SqlParameter("ContactId", cidr.ContactId));
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            return responseCase;
        }
    }
}
