using inin.Bridge.WebServices.Datadip.Lib;
using webservice_datadip_connector_sql.DataAccess.Repositories;

namespace webservice_datadip_connector_sql.DataAccess.Services
{
    public class CaseService
    {
        private CaseRepository _CaseRepository;
        public CaseService(CaseRepository _CaseRepository)
        {
            this._CaseRepository = _CaseRepository;
        }
        public ResponseCase GetMostRecentOpenCaseByContactId(ContactIdRequest cidr)
        {
            return this._CaseRepository.GetMostRecentOpenCaseByContactId(cidr);
        }
    }
}
