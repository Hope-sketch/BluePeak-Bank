using System;
using Microsoft.AspNetCore.Mvc;
using BluePeakBank.Data;
using BluePeakBank.Web.Models;

namespace BluePeakBank.Web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var customers = _context.Customers.ToList();

            return View(customers);
        }
    }
}
