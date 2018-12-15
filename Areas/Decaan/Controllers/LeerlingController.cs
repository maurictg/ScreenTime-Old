using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LIST.Data;
using LIST.Models;

namespace LIST_Core.Areas.Decaan.Controllers
{
    [Area("Decaan")]
    [Route("decaan/[controller]/[action]")]
    public class LeerlingController : Controller
    {
        private readonly LeerlingContext _context;

        public LeerlingController(LeerlingContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Leerlingen);
        }

        [HttpGet("{id?}")]
        public IActionResult Edit(int? id)
        {
            if(id != null)
            {
                var data = _context.Leerlingen.Where(l => l.Id == id).FirstOrDefault();
                return View(data);
            }
            else
            {
                return View(null);
            }
        }


        public async Task<IActionResult> Save(Student student)
        {
            var data = _context.Leerlingen.Where(s => s.Id == student.Id).FirstOrDefault();
            try
            {
                if (ModelState.IsValid)
                {
                    data.Lastname = student.Lastname;
                    data.Name = student.Name;
                    data.Phone = student.Phone;
                    data.Postcode = student.Postcode;
                    data.Adress = student.Adress;
                    data.Residence = student.Residence;
                    data.Postcode = student.Postcode;
                    data.Email = student.Email;
                    await _context.SaveChangesAsync();

                    ViewBag.Message = "[Suc]Wijzigingen opgeslagen!";
                    return View("Edit", student);
                }
                else
                {
                    ViewBag.Message = "[Err]Gegevens onjuist";
                    return View("Edit", student);
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = "[Err]Opslaan mislukt, " + ex.ToString();
                return View("Edit", student);
            }

        }


        public async Task<IActionResult> Add([Bind("Lastname,Name,Phone,Postcode,Adress,Residence,Email,Prefix,Token,Studentcode")] Student student)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(student);
                    await _context.SaveChangesAsync();
                    ViewBag.Message = "[Suc]Gebruiker toegevoegd!";
                    return View("Edit", student);
                }
                catch(Exception ex)
                {
                    ViewBag.Message = "[Err]"+ex.ToString();
                    return View("Edit", student);
                }
            }
            else
            {
                ViewBag.Message = "[Err]Gegevens onjuist";
                return View("Edit", student);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Student student)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Remove(student);
                    await _context.SaveChangesAsync();
                    ViewBag.Message = "[Suc]Gebruiker verwijderd!";
                    return View("Index", _context.Leerlingen);
                }
                catch (Exception ex)
                {
                    ViewBag.Message = "[Err]" + ex.ToString();
                    return View("Edit", student);
                }
            }
            else
            {
                ViewBag.Message = "[Err]Gegevens onjuist";
                return View("Edit", student);
            }
        }


        public async Task<IActionResult> Edittw(int id, [Bind("Id,Lastname,Name,Phone,Postcode,Adress,Residence,Email")] Student student)
        {
            //GAAT FOUT: Overige kolommen worden niet geupdated, maar gewist en worden wordt NULL
            if (id != student.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception /* ex */)
                {
                    //Log the error (uncomment ex variable name and write a log.)
                    ModelState.AddModelError("", "Unable to save changes. " +
                        "Try again, and if the problem persists, " +
                        "see your system administrator.");
                }
            }
            return View(_context.Leerlingen.Where(s => s.Id == id).FirstOrDefault());
        }
    }
}