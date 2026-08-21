using Microsoft.Identity.Client;
using System;

namespace BluePeakBank.Web.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string IdentityNumber { get; set; }
        public AccountStatus accountStatus { get; set; }
        public DocumentType documenttype { get; set; }
    }
}
