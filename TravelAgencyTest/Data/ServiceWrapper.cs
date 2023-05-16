using TravelAgencyTest.Data.IServices;
using TravelAgencyTest.Data.Services;

namespace TravelAgencyTest.Data
{
    public class ServiceWrapper : IServiceWrapper
    {
        private IAirlineCompanyService _airlineCompanyService;
        public IHolidayService _holidayService;
        public IHotelService _hotelService;
        public IReviewService _reviewService;
        public ITicketService _ticketService;

        private ApplicationDbContext _repoContext;

        public IAirlineCompanyService AirlineCompanyService
        {
            get
            {
                return _airlineCompanyService ?? (_airlineCompanyService = new AirlineCompanyService(_repoContext));
            }
        }

        public IHolidayService HolidayService
        {
            get
            {
                return _holidayService ?? (_holidayService = new HolidayService(_repoContext));
            }
        }

        public IHotelService HotelService
        {
            get
            {
                return _hotelService ?? (_hotelService = new HotelService(_repoContext));
            }
        }

        public IReviewService ReviewService
        {
            get
            {
                return _reviewService ?? (_reviewService = new ReviewService(_repoContext));
            }
        }

        public ITicketService TicketService
        {
            get
            {
                return _ticketService ?? (_ticketService = new TicketService(_repoContext));
            }
        }

        public ServiceWrapper(ApplicationDbContext repoContext)
        {
            _repoContext = repoContext;
        }
    }
}
