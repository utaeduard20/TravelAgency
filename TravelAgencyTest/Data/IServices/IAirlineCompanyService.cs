using TravelAgencyTest.Models;

namespace TravelAgencyTest.Data.IServices
{
    public interface IAirlineCompanyService : IAbstractService<AirlineCompany>
    {
        bool DoesAirlineCompanyExists(AirlineCompany company);
    }
}
