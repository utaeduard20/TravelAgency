using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TravelAgencyTest.Models;

namespace TravelAgencyTest.Models
{
    public class Holiday
    {
      
        public int HolidayId { get; set; }
        public string Title { get; set; }
        public string City { get; set; }

        public virtual Hotel Hotel { get; set; } //un holiday are un hotel
        public ICollection <Ticket> Tickets { get; set; }// un holiday are mai multe tichete one to many
        public ICollection <Review> Reviews { get; set; }// un holiday are mai multe review-uri one to many

       
    }
}
