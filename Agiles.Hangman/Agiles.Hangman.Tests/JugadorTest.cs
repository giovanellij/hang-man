using Agiles.Hangman.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Agiles.Hangman.Tests
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
