using LogInAPIS.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LogInAPIS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<LogIn> _logger;

        public HomeController(ILogger<LogIn> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

       

    }
}