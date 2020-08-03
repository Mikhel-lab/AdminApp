using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddmonApp.Areas.Identity.Data;
using AddmonApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AddmonApp.Data
{
    public class AddmonAppContext : IdentityDbContext<AddmonAppUser>
    {
        public AddmonAppContext(DbContextOptions<AddmonAppContext> options)
            : base(options)
        {
        }

        //custom entity, override identity user with new column
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        //custom entity, for simple todo app
        public DbSet<Todo> Todo { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
