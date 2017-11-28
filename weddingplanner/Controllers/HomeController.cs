using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using weddingplanner.Models;

namespace weddingplanner.Controllers
{
    [Route("[Controller]/[action]")]
    public class HomeController : Controller
    {

        /*private WeddingplannerContext _context;
        public HomeController(WeddingplannerContext context)
        { _context = context;
        }

        [HttpGet]
        [Route("")]
        */
        [HttpGet]
        [Route("/Home/Index")]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}