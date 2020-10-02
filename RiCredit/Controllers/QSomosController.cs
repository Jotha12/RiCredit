using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ricredit.Controllers
{
    public class QSomosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}