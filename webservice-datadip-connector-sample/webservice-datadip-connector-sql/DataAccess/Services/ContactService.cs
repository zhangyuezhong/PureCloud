using inin.Bridge.WebServices.Datadip.Lib;
using webservice_datadip_connector_sql.DataAccess.Repositories;

namespace webservice_datadip_connector_sql.DataAccess.Services
{
    public class ContactService
    {
        private ContactRepository _ContactRepository;
        public ContactService(ContactRepository _ContactRepository)
        {
            this._ContactRepository = _ContactRepository;
        }

        public ResponseContact GetContactByPhoneNumber(PhoneNumberRequest req)
        {
            return this._ContactRepository.GetContactByPhoneNumber(req);
        }
    }
}
