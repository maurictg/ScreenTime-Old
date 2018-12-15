using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LIST.Data;
using LIST.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace LIST.Areas.Leerling.Controllers
{
    [Area("Leerling")]
    [Route("leerling/[controller]")]
    public class HomeController : Controller
    {
        private readonly LeerlingContext _context;

        public HomeController(LeerlingContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            string token = HttpContext.Session.GetString("Token");
            if (token != null)
            {
                var data = _context.Leerlingen
                                   .Where(s => s.Token == token)
                                   .FirstOrDefault();
                HttpContext.Session.SetInt32("Studentcode", data.Studentcode);
                ViewBag.Message = "[Inf]Welkom " + data.Name + " " + data.Lastname + "!";
                return View(data);
            }
            else
            {
                return Content("No token");
            }
        }
    }
}


