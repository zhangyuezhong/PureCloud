using inin.Bridge.WebServices.Datadip.Lib;
using System;
using System.Data.SqlClient;

namespace webservice_datadip_connector_sql.DataAccess.Repositories.Impl
{
    public class AccountRepositoryImpl : AccountRepository
    {

        private DataSource _DataSource;

        public AccountRepositoryImpl(DataSource _DataSource)
        {
            this._DataSource = _DataSource;
        }
        public ResponseAccount GetAccountByAccountNumber(AccountNumberRequest req)
        {
            ResponseAccount responseAccount = new ResponseAccount();
            responseAccount.Account = new Account();
            try
            {
                using (SqlConnection con = _DataSource.getSqlConnection())
                {
                    con.Open();
                    string sql = "SELECT * FROM Accounts where AccountNumber=@AccountNumber";
                    using (SqlCommand command = new SqlCommand(sql, con))
                    {
                        command.Parameters.Add(new SqlParameter("AccountNumber", req.AccountNumber));
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
            return responseAccount;
        }

        public ResponseAccount GetAccountByContactId(ContactIdRequest cidr)
        {
            ResponseAccount responseAccount = new ResponseAccount();
            responseAccount.Account = new Account();
            try
            {
                using (SqlConnection con = _DataSource.getSqlConnection())
                {
                    con.Open();
                    string sql = "SELECT * FROM Accounts where ContactId=@ContactId";
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
            return responseAccount;
        }

        public ResponseAccount GetAccountByPhoneNumber(PhoneNumberRequest req)
        {
            ResponseAccount responseAccount = new ResponseAccount();
            responseAccount.Account = new Account();
            try
            {
                using (SqlConnection con = _DataSource.getSqlConnection())
                {
                    con.Open();
                    string sql = "SELECT * FROM Accounts where PhoneNumber=@PhoneNumber";
                    using (SqlCommand command = new SqlCommand(sql, con))
                    {
                        command.Parameters.Add(new SqlParameter("PhoneNumber", req.PhoneNumber));
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
            return responseAccount;
        }
    }
}
