using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LIST.Data;
using LIST.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace LIST.Areas.Leerling.Controllers
{
    [Area("Leerling")]
    [Route("leerling/[controller]/[action]")]
    public class LOBController : Controller
    {
        private readonly LOBContext _context;

        public LOBController(LOBContext context)
        {
            _context = context;
        }


        public ActionResult Index()
        {
            var data = _context.Opdrachten.Where(s => s.Studentcode.Equals(HttpContext.Session.GetInt32("Studentcode")));
            return View(data);
        }

        [HttpGet("{id}")]
        public ActionResult Opdrachten(int? id)
        {
             var data = _context.Opdrachten.Where(s => s.Studentcode.Equals(HttpContext.Session.GetInt32("Studentcode")) && s.Id.Equals(id)).FirstOrDefault();
             return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> postOpdrachten(LOBOrders opdracht)
        {
            int? code = HttpContext.Session.GetInt32("Studentcode");
            var data = _context.Opdrachten
                            .Where(s => s.Studentcode == code && s.Id == opdracht.Id)
                            .FirstOrDefault();
            try
            {
                if (ModelState.IsValid)
                {
                    data.Data = opdracht.Data;
                    await _context.SaveChangesAsync();

                    ViewBag.Message = "[Suc]Wijzigingen opgeslagen!";
                    return View("Opdrachten", opdracht);
                }
                else
                {
                    ViewBag.Message = "[Err]Gegevens onjuist";
                    return View("Opdrachten", opdracht);
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = "[Err]Opslaan mislukt, " + ex.ToString();
                return View("Opdrachten", opdracht);
            }
        }
    }
}