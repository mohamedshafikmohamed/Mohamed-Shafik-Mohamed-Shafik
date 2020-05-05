using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mohamed_Shafik_Mohamed_Shafik.Models;
using Microsoft.CodeAnalysis;
using Microsoft.Extensions.Hosting;
using System.IO;

namespace Mohamed_Shafik_Mohamed_Shafik.Controllers
{
    public class HomeController : Controller
    {
        private readonly DateContext d;
        private readonly ILogger<HomeController> _logger;
        

        public HomeController(ILogger<HomeController> logger, DateContext d1 )
        {
            d = d1;
           
            
            _logger = logger;
        }

        public IActionResult Index()
        {
            info_projects x = new info_projects();
            x.inf = d.info.SingleOrDefault();
            x.projects = d.projects.ToList();
           
            return View(x);
        }
        public IActionResult Projects()
        {


            return View(d.projects.ToList());
        }
        public IActionResult add_project()
        {
           


            return View();
        }
        [HttpPost]
        public IActionResult add_project(Projects p )

        {

          
            d.projects.Add(p);
            d.SaveChanges();
            return View();
        }
        [HttpPost]
        public IActionResult Delete(int id )
        {
            d.projects.Remove(d.projects.Find(id));
            d.SaveChanges();

            return RedirectToAction("Projects");
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
