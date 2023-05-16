using System.Linq;
using TravelAgencyTest.Data.IServices;
using TravelAgencyTest.Models;

namespace TravelAgencyTest.Data.Services
{
    public class AirlineCompanyService : AbstractService<AirlineCompany>, IAirlineCompanyService
    {
        public AirlineCompanyService(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {
        }

        public bool DoesAirlineCompanyExists(AirlineCompany company)
        {
            return FindByCondition(c => c.AirlineId == company.AirlineId).Any();
        }
    }
}
