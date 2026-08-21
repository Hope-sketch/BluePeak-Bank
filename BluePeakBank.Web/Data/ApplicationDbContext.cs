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
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Loan> Loan { get; set; }
    }
}
