using Microsoft.AspNetCore.Mvc;

namespace AspireHub.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
