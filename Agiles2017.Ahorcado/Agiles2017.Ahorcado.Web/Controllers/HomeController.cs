using Agiles2017.Ahorcado.Modelo;
using Agiles2017.Ahorcado.Web.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Agiles2017.Ahorcado.Web.Controllers
{
    public class HomeController : Controller
    {
        private const string PARTIDA = "partida";
        private const string PROVEEDOR = "proveedor";

        public HomeController() { }
        
        public ActionResult Index()
        {
            CargarPalabras();
            return View();
        }

        [Route("Home/Nueva")]
        public JsonResult NuevaPartida(string letra)
        {
            IPartida partida = new Partida(GetProveedor().Nueva(), 6);

            Session.Add(PARTIDA, partida);

            return Json(new PartidaViewModel(partida), JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        [Route("Home/Probar/{letra}")]
        public JsonResult Probar(string letra)
        {
            IPartida partida = GetPartida();

            partida.IngresarLetra(letra);

            return Json(new PartidaViewModel(partida), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        [Route("Home/Arriesgar/{palabraCompleta}")]
        public JsonResult Arriesgar(string palabraCompleta)
        {
            IPartida partida = GetPartida();

            partida.Arriesgar(palabraCompleta);

            return Json(new PartidaViewModel(partida), JsonRequestBehavior.AllowGet);
        }

        private IPartida GetPartida()
        {
            return (IPartida)Session[PARTIDA];
        }

        private IProveedorDePalabras GetProveedor()
        {
            return (IProveedorDePalabras)Session[PROVEEDOR];
        }

        private void CargarPalabras()
        {
            if (Session[PROVEEDOR] == null)
            {
                ICollection<string> _palabras = new List<string>();
                _palabras.Add("fernet");
                _palabras.Add("computadora");
                _palabras.Add("cerveza");
                _palabras.Add("etimologia");
                _palabras.Add("universidad");
                _palabras.Add("electrolitos");
                _palabras.Add("caleidoscopio");
                Session.Add(PROVEEDOR, new ProveedorDePalabras(_palabras));
            }
        }
    }
}