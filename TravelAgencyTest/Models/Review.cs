using System;
using System.ComponentModel.DataAnnotations;

namespace TravelAgencyTest.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Rating { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }


        public int HolidayId { get; set; }
        public Holiday Holiday { get; set; }

    }
}
