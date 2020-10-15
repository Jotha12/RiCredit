using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ricredit.Controllers
{
    public class NSolicitudController : Controller
    {
        public IActionResult NSolicitud()
        {
            return View();
        }
    }
}