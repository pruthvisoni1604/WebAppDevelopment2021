using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GBCSporting2021_.Models;

namespace GBCSporting2021_.Controllers
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

        //public IActionResult Index(string topic, string category)
        //{
        //    ViewBag.Country = ctx.Countries.OrderBy(c => c.CountryId).ToList();

        //    //IQueryable<FAQ> faqs = ctx.FAQS
        //    //    .Include(f => f.Topic)
        //    //    .Include(f => f.Category)
        //    //    .OrderBy(f => f.Question);

        //    //if (!string.IsNullOrEmpty(topic))
        //    //    faqs = faqs.Where(f => f.TopicId == topic);

        //    //return View(faqs.ToList());

        //    return View();
        //}
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
