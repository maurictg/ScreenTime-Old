using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LIST.Data;
using LIST.Models;

namespace LIST_Core.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/[controller]/[action]")]

    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
    }
}