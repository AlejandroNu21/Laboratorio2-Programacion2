using LABORATORIO_2_PROGRAMACION_2.Dominio;
using LABORATORIO_2_PROGRAMACION_2.Models;
using LABORATORIO_2_PROGRAMACION_2.Models.ViewModel;
using LABORATORIO_2_PROGRAMACION_2.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LABORATORIO_2_PROGRAMACION_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IDatos idatos;
        public HomeController(ILogger<HomeController> logger, IDatos idatos)
        {
            this.idatos = idatos;
            _logger = logger;
        }

        public IActionResult Index()
        {


            return View();
        }


        public IActionResult DescripcionViewModel(EntidadViewModel entidad)
        {
            if (!ModelState.IsValid)
            {
                return View("EntidadViewModel", entidad);
            }
            return Redirect("EntidadViewModel");
        }

        public IActionResult DescripcionViewModel()
        {
            return View();
        }

        public IActionResult EntidadViewModel()
        {
            return View();
        }

        public IActionResult GetAll() 
        {
            var DandoFormatoJson = idatos.listardatos();

            return Json(new { data = DandoFormatoJson });
        
        }
         public IActionResult Guardado()
        {


            return View();
         }

        public IActionResult Listado()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
