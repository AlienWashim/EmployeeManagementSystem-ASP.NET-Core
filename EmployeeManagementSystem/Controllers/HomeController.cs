using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        // Action to return the Index view
        public IActionResult Index()
        {
            return View();
        }

        // Action to return an About view
        public IActionResult About()
        {
            return View();
        }

        // Action to handle errors (optional)
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}
