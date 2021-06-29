using Microsoft.AspNetCore.Mvc;
using MusicZone4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicZone4.Controllers
{
    public class BandasController : Controller
    {
        public IActionResult Index()
        {
            List<Banda> bandas = Repositorio.Bandas;
            return View(bandas);
        }

        public IActionResult AddBanda()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBanda(Banda novaBanda)
        {
            if (ModelState.IsValid)
            {
                Repositorio.AddBanda(novaBanda);
                return View("BandaConfirmada", novaBanda);
            }
            return View();
        }
    }
}
