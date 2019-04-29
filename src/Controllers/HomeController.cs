using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using elastic_kibana.Models;
using Microsoft.Extensions.Logging;

namespace elastic_kibana.Controllers
{
    public class HomeController : Controller
    {
        ILogger<HomeController> logger;
        public HomeController(ILoggerFactory factory)
        {
            logger = factory.CreateLogger<HomeController>();    
        }

        public IActionResult Index()
        {
            logger.LogTrace("Index fired");
            return View();
        }

        public IActionResult Privacy()
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
