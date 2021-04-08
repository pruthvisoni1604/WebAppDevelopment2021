using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GBCSporting2021_DynamicDevelopers.Models;
using Microsoft.EntityFrameworkCore;

namespace GBCSporting2021_DynamicDevelopers.Controllers
{
    public class HomeController : Controller
    {
        private Context ctx { get; set; }

        public HomeController(Context cctx)
        {
            ctx = cctx;
        }

        public IActionResult Index()
        {
            var data = ctx.Countries.OrderBy(c => c.CountryId).ToList();
            return View(data);
        }
        public IActionResult About()
        {
            ViewData["Message"] = "This is our about page, SportsPro provide all services to customers as well as technicians.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact US";

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
