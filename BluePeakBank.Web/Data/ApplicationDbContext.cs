using System;
using BluePeakBank.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace BluePeakBank.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
    }
}
