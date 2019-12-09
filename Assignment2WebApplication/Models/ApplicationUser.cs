using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2WebApplication.Models
{
    public class ApplicationUser : IdentityUser<string>
    {
        [Column(TypeName = "nvarchar(999)")]
        [DisplayName("First Name")]
        public String FirstName { get; set; }

        [Column(TypeName = "nvarchar(999)")]
        [DisplayName("Last Name")]
        public String LastName { get; set; }
        
        [DisplayName("Phone Number")]
        override public String PhoneNumber { get; set; }
    }
}
