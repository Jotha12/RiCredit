using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RiCredit.Models;

namespace RiCredit.Controllers
{
    public class PrincipalController : Controller
    {
        public IActionResult Principal()

            

        {
            Principal obj = new Principal();

            obj.Nombre = "Jonatan";

            return View(obj);
        }
    }
}