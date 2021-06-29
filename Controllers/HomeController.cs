using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MusicZone4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MusicZone4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Conceito()
        {
            ConceitoViewModel conceitoViewModel = new ConceitoViewModel()
            {
                TotalBandas = Repositorio.TotalBandas(),
                TotalBandasPop = Repositorio.TotalBandasPop()
            };
            return View(conceitoViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}