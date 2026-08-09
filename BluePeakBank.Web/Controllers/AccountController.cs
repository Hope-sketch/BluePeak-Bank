using Microsoft.AspNetCore.Mvc;

namespace BluePeakBank.Web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
