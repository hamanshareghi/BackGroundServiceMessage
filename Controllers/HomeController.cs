using BackGroundServiceMessage.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using BackGroundServiceMessage.Data;
using BackGroundServiceMessage.Services;

namespace BackGroundServiceMessage.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IDataService _dataService;

        public HomeController(ILogger<HomeController> logger, IDataService dataService)
        {
            _logger = logger;
            _dataService = dataService;
        }

        public IActionResult Index()
        {
           
            return View();
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}