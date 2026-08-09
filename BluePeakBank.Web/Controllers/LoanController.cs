using Microsoft.AspNetCore.Mvc;

namespace BluePeakBank.Web.Controllers
{
    public class LoanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
