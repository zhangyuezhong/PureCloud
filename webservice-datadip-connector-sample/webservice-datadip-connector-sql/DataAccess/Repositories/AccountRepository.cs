using inin.Bridge.WebServices.Datadip.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webservice_datadip_connector_sql.DataAccess.Repositories
{
    public interface AccountRepository
    {
         ResponseAccount GetAccountByAccountNumber(AccountNumberRequest req);
         ResponseAccount GetAccountByContactId(ContactIdRequest cidr);
         ResponseAccount GetAccountByPhoneNumber(PhoneNumberRequest req);

    }
}
