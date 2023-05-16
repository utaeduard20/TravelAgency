using TravelAgencyTest.Data.IServices;
using TravelAgencyTest.Models;

namespace TravelAgencyTest.Data.Services
{
    public class ReviewService : AbstractService<Review>, IReviewService
    {
        public ReviewService(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {
        }

    }
}
