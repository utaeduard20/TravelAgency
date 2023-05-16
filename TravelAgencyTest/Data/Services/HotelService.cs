using TravelAgencyTest.Data.IServices;
using TravelAgencyTest.Models;

namespace TravelAgencyTest.Data.Services
{
    public class HotelService : AbstractService<Hotel>, IHotelService
    {
        public HotelService(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {
        }

    }
}