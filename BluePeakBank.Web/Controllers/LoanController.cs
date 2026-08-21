using System;
using Microsoft.AspNetCore.Mvc;
using BluePeakBank.Data;
using BluePeakBank.Web.Models;

namespace BluePeakBank.Web.Controllers
{
    public class LoanController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LoanController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var loans = _context.Loan.ToList();

            return View(loans);
        }
    }
}
