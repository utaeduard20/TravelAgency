using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TravelAgencyTest.Models
{
    public class AirlineCompany
    {
        [Key]
        public int AirlineId { get; set; }
        public string Name { get; set; }

        public ICollection<Ticket> Tickets { get; set; }


    }
}
