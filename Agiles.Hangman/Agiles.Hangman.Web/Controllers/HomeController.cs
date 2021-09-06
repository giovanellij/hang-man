using Agiles.Hangman.Model;
using Agiles.Hangman.Web.Helpers;
using Agiles.Hangman.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;

namespace Agiles.Hangman.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly string _gameSessionKey = "partida";
        private readonly string _wordGeneratorSessionKey = "proveedor";

        public IActionResult Index()
        {
            CargarPalabras();

            return View();
        }

        [Route("Home/Nueva")]
        public JsonResult NuevaPartida(string letra)
        {
            IPartida partida = new Partida(GetProveedor().Nueva(), 6);

            HttpContext.Session.SetObjectAsJson(_gameSessionKey, partida);

            return Json(new PartidaViewModel(partida));
        }

        [HttpGet]
        [Route("Home/Probar/{letra}")]
        public JsonResult Probar(string letra)
        {
            IPartida partida = GetPartida();

            partida.IngresarLetra(letra);

            HttpContext.Session.SetObjectAsJson(_gameSessionKey, partida);

            return Json(new PartidaViewModel(partida));
        }

        [HttpGet]
        [Route("Home/Arriesgar/{palabraCompleta}")]
        public JsonResult Arriesgar(string palabraCompleta)
        {
            IPartida partida = GetPartida();

            partida.Arriesgar(palabraCompleta);

            return Json(new PartidaViewModel(partida));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private void CargarPalabras()
        {
            if (HttpContext.Session.GetObjectFromJson<ProveedorDePalabras>(_wordGeneratorSessionKey) == null)
            {
                var wordProvider = new ProveedorDePalabras(new List<string>
                {
                    "casa",
                    "roma",
                    "argentina",
                    "casiopea"
                });

                HttpContext.Session.SetObjectAsJson(_wordGeneratorSessionKey, wordProvider);
            }
        }

        private IPartida GetPartida()
        {
            return HttpContext.Session.GetObjectFromJson<Partida>(_gameSessionKey);
        }

        private IProveedorDePalabras GetProveedor()
        {
            return HttpContext.Session.GetObjectFromJson<ProveedorDePalabras>(_wordGeneratorSessionKey);
        }
    }
}
