﻿using System.ComponentModel.DataAnnotations;

namespace TravelAgencyTest.Models
{
    public class ContactFormModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Message { get; set; }
    }
}
