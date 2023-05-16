using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelAgencyTest.Models
{
    public class Ticket
    {

        public int TicketId { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        //[DataType(DataType.Date)] //adaugat ora
        public DateTime Departure { get; set; }

        //[DataType(DataType.Date)] //adaugat ora
        public DateTime Arrival { get; set; }

        public string Duration { get; set; }


        public int HolidayId { get; set; }
        public Holiday Holiday { get; set; }

        public int AirlineId { get; set; }
        public AirlineCompany AirlineCompany { get; set; }

    }
}
