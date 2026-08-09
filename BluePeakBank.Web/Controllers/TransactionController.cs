using Microsoft.AspNetCore.Mvc;

namespace BluePeakBank.Web.Controllers
{
    public class TransactionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
