using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BudgetCalculation.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}