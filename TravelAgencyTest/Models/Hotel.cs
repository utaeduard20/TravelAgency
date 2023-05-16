using System.ComponentModel.DataAnnotations.Schema;

namespace TravelAgencyTest.Models
{
    public class Hotel
    {
        [ForeignKey("Holiday")]
        public int HotelId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public bool AllInclusive { get; set; }
        public bool Healthcare { get; set; }
        public int Days { get; set; }
        public int Rooms { get; set; }

        public int HolidayId { get; set; }
        public virtual Holiday Holiday { get; set; } //un hotel are camera rezerevata pentru un holiday

    }
}
