using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using StrongTogether.Models;

namespace StrongTogether.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<StrongTogether.Models.Profile> Profile { get; set; }
        public DbSet<StrongTogether.Models.Contact> Contact { get; set; }
    }
}
