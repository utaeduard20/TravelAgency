using TravelAgencyTest.Data.IServices;
using TravelAgencyTest.Models;

namespace TravelAgencyTest.Data.Services
{
    public class HolidayService : AbstractService<Holiday>, IHolidayService
    {
        public HolidayService(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {
        }

    }
}