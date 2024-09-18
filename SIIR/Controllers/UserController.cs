using Microsoft.AspNetCore.Mvc;
using SIIR.Models;
using System.Diagnostics;

namespace SIIR.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        public IActionResult Information()
        {
            return View();
        }

        public IActionResult Dashboard(string userType)
        {
            switch (userType.ToLower())
            {
                case "admin":
                    return View("AdminDashboard");
                case "student":
                    return View("StudentDashboard");
                case "coach":
                    return View("CoachDashboard");
                default:
                    return RedirectToAction("Login", "Home");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}