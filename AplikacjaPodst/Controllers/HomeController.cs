using AplikacjaPodst.DAL;
using AplikacjaPodst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AplikacjaPodst.Controllers
{
    public class HomeController : Controller
    {
        WarzywaContext context;

        public HomeController(WarzywaContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public IActionResult Index(Warzywo warzywo)
        {
            if (warzywo.WarzywoId == 0)
            {
                context.Warzywa.Add(warzywo);
            }
            else
            {
                context.Warzywa.Update(warzywo);
            }
            context.SaveChanges();

            ViewBag.vegetables = context.Warzywa.ToList();

            return View();
        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.vegetables = context.Warzywa.ToList();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Polska()
        {
            var warzywa = context.Warzywa.ToList();
            List<Warzywo> warzywazPolski = new List<Warzywo>();
            foreach(var warzywo in warzywa)
            {
                if (warzywo.Country == "Polska")
                {
                    warzywazPolski.Add(warzywo);
                }
            }
            ViewBag.krajowe = warzywazPolski;
            return View();
        }

        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                return View(new Warzywo());
            }
            return View(context.Warzywa.Find(id));
        } 
        public IActionResult Delete(int id)
        {
            var warzywo = context.Warzywa.Find(id);
            context.Remove(warzywo);
            context.SaveChanges();

            ViewBag.vegetables = context.Warzywa.ToList();

            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    };
}
