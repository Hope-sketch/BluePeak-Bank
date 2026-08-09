using System;
using Microsoft.AspNetCore.Mvc;
using BluePeakBank.Data;

namespace BluePeakBank.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var accounts = _context.Accounts.ToList();

            return View(accounts);
        }
    }
}
