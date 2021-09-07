using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Agiles2017.Ahorcado.Modelo.Tests
{
    [TestClass]
    public class JugadorTest
    {
        [TestMethod]
        public void Jugador_CuandoSeCrea_DebeAsignarNombre()
        {
            IJugador jugador = new Jugador("PepeArgento");
            Assert.AreEqual(jugador.Nombre, "PepeArgento"); 
        }
    }
}
