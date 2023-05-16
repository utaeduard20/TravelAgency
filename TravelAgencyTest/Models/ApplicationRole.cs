using Microsoft.AspNetCore.Identity;
using System;

namespace TravelAgencyTest.Models
{
    public class ApplicationRole : IdentityRole
    {
        public DateTime CreationData { get; set; }

        public ApplicationRole() : base() { }
        public ApplicationRole(string roleName) : base(roleName)
        {

        }

        public ApplicationRole(string roleName, DateTime creationData) : base(roleName)
        {
            this.CreationData = creationData;

        }


    }
}
