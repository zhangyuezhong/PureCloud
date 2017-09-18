using inin.Bridge.WebServices.Datadip.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webservice_datadip_connector_sql.DataAccess.Repositories;

namespace webservice_datadip_connector_sql.DataAccess.Services
{
    public class AccountService
    {
        private AccountRepository _AccountRepository;
        public AccountService(AccountRepository _AccountRepository)
        {
            this._AccountRepository = _AccountRepository;
        }
        public ResponseAccount GetAccountByAccountNumber(AccountNumberRequest req)
        {
            return this._AccountRepository.GetAccountByAccountNumber(req);
        }
        public ResponseAccount GetAccountByContactId(ContactIdRequest cidr)
        {
            return this._AccountRepository.GetAccountByContactId(cidr);
        }
        public ResponseAccount GetAccountByPhoneNumber(PhoneNumberRequest req)
        {
            return this._AccountRepository.GetAccountByPhoneNumber(req);
        }
    }
}
