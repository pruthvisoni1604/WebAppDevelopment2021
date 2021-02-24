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
        //[HttpGet]
        //public IActionResult Add()
        //{
        //    ViewBag.Action = "Add";
        //    ViewBag.Genres = context.Genres.OrderBy(g => g.Name).ToList();
        //    return View("Edit", new Movie());
        //}

        //[HttpGet]
        //public IActionResult Edit(int id)
        //{
        //    ViewBag.Action = "Edit";
        //    ViewBag.Genres = context.Genres.OrderBy(g => g.Name).ToList();
        //    var movie = context.Movies.Find(id);
        //    return View(movie);
        //}

        //[HttpPost]
        //public IActionResult Edit(Movie movie)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        if (movie.MovieId == 0)
        //            context.Movies.Add(movie);
        //        else
        //            context.Movies.Update(movie);
        //        context.SaveChanges();
        //        return RedirectToAction("Index", "Home");
        //    }
        //    else
        //    {
        //        ViewBag.Action = (movie.MovieId == 0) ? "Add" : "Edit";
        //        ViewBag.Genres = context.Genres.OrderBy(g => g.Name).ToList();
        //        return View(movie);
        //    }
        //}

        //[HttpGet]
        //public IActionResult Delete(int id)
        //{
        //    var movie = context.Movies.Find(id);
        //    return View(movie);
        //}

        //[HttpPost]
        //public IActionResult Delete(Movie movie)
        //{
        //    context.Movies.Remove(movie);
        //    context.SaveChanges();
        //    return RedirectToAction("Index", "Home");
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
