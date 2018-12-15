using System;
using System.Web;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using LIST.Models;
using LIST.Data;

namespace LIST.Controllers
{
    public class HomeController : Controller
    {
        private readonly NewsContext _context;

        public HomeController(NewsContext context)
        {
            _context = context;
        }
        
        public ActionResult Index()
        {
            return View(_context.Nieuws);
        }

        public ActionResult Nieuws(int? id)
        {
            if (id != null)
            {
                var data = _context.Nieuws.Where(s => s.Id == id);
                return View(data);
            }
            else
            {
                return View(_context.Nieuws);
            }
            
        }
 

    }
}