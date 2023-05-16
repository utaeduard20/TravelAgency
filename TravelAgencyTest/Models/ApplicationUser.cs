﻿using Microsoft.AspNetCore.Identity;

namespace TravelAgencyTest.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() : base() { }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string Country { get; set; }
        
    }
}
