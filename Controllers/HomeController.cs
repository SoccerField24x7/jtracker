using System;
using System.Diagnostics;
using JTracker.jtcontext;
using JTracker.jtcontext.Models;
using JTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace JTracker.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            using (var context = new JTContext())
            {
                var entry = new Log {
                    LogLevel = 3,
                    SourcePage = "UNKNOWN",
                    SQL = "",
                    Message = "blah",
                    Generated = DateTime.Now,
                };

                context.Add(entry);
                context.SaveChanges();
            }

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
