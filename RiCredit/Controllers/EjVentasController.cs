using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ricredit.Controllers
{
    public class EjVentasController : Controller
    {
        public IActionResult EjVentas()
        {
            return View();
        }
    }
}