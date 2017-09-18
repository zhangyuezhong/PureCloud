
using inin.Bridge.WebServices.Datadip.Lib;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace webservice_datadip_connector_sql.DataAccess.Repositories.Impl
{
    public class ContactRepositoryImpl : ContactRepository
    {
        private DataSource _DataSource;

        public ContactRepositoryImpl(DataSource _DataSource)
        {
            this._DataSource = _DataSource;
        }
        public ResponseContact GetContactByPhoneNumber(PhoneNumberRequest req)
        {
            ResponseContact responseContact = new ResponseContact();
            responseContact.Contact = new Contact();
            try
            {
                using (SqlConnection con = _DataSource.getSqlConnection())
                {
                    con.Open();
                    string sql = "SELECT * FROM Contacts where PhoneNumber=@PhoneNumber";
                    using (SqlCommand command = new SqlCommand(sql, con))
                    {
                        command.Parameters.Add(new SqlParameter("PhoneNumber", req.PhoneNumber));
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                responseContact.Contact.FirstName = reader.GetString(0);
                                responseContact.Contact.LastName = reader.GetString(0);
                                EmailAddresses emails = new EmailAddresses();
                                emails.EmailAddress = new List<EmailAddressModel>();

                                EmailAddressModel workEmail = new EmailAddressModel();
                                workEmail.EmailType = 1;
                                workEmail.EmailAddress = "sample@sample.com";
                                emails.EmailAddress.Add(workEmail);

                                responseContact.Contact.EmailAddresses = emails;
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            return responseContact;
        }
    }
}
