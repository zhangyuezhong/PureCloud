
using inin.Bridge.WebServices.Datadip.Lib;
using System.ServiceModel;
using System.ServiceModel.Activation;
using webservice_datadip_connector_sql.DataAccess;
using webservice_datadip_connector_sql.DataAccess.Repositories.Impl;
using webservice_datadip_connector_sql.DataAccess.Services;
namespace webservice_datadip_connector_sql.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple, IncludeExceptionDetailInFaults = true)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class SQLWebServicesImplementation : IWebServicesServer
    {
        private AccountService _AccountService;
        private ContactService _ContactService;
        private CaseService _CaseService;
      
        public SQLWebServicesImplementation(string connectionString)
        {
            DataSource dataSource = new DataSource(connectionString);
            this._AccountService = new AccountService(new AccountRepositoryImpl(dataSource));
            this._ContactService = new ContactService(new ContactRepositoryImpl(dataSource));
            this._CaseService = new CaseService(new CaseRepositoryImpl(dataSource));
        }
        
        public ResponseAccount GetAccountByAccountNumber(AccountNumberRequest req)
        {
            return this._AccountService.GetAccountByAccountNumber(req);
        }

        public ResponseAccount GetAccountByContactId(ContactIdRequest cidr)
        {
            return this._AccountService.GetAccountByContactId(cidr);
        }

        public ResponseAccount GetAccountByPhoneNumber(PhoneNumberRequest req)
        {
            return this._AccountService.GetAccountByPhoneNumber(req);
        }

        public ResponseContact GetContactByPhoneNumber(PhoneNumberRequest req)
        {
            return this._ContactService.GetContactByPhoneNumber(req);
        }

        public ResponseCase GetMostRecentOpenCaseByContactId(ContactIdRequest cidr)
        {
            return this._CaseService.GetMostRecentOpenCaseByContactId(cidr);
        }
    }
}
