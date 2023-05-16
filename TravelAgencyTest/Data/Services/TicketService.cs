using TravelAgencyTest.Data.IServices;
using TravelAgencyTest.Models;

namespace TravelAgencyTest.Data.Services
{
    public class TicketService : AbstractService<Ticket>, ITicketService
    {
        public TicketService(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {
        }

    }
}
