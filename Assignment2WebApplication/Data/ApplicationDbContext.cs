using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Assignment2WebApplication.Models;

namespace Assignment2WebApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Assignment2WebApplication.Models.Room> Room { get; set; }
        public DbSet<Assignment2WebApplication.Models.Suite> Suite { get; set; }

    }
}
