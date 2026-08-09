using Microsoft.AspNetCore.Mvc;

namespace BluePeakBank.Web.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
