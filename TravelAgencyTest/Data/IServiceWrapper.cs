using TravelAgencyTest.Data.IServices;

namespace TravelAgencyTest.Data
{
    public interface IServiceWrapper
    {
        IAirlineCompanyService AirlineCompanyService { get; }
        IHolidayService HolidayService { get; }
        IHotelService HotelService { get; }
        IReviewService ReviewService { get; }
        ITicketService TicketService { get; }
    }
}
