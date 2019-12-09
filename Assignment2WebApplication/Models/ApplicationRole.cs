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
    public class ApplicationRole : IdentityRole<string>
    {
        [Column(TypeName = "nvarchar(999)")]
        [DisplayName("Application Role")]
        public String RoleDescription { get; set; }
    }
}
