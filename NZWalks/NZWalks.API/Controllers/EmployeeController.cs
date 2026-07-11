using Microsoft.AspNetCore.Mvc;

namespace NZWalks.API.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
