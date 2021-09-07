using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Agiles2017.Ahorcado.Modelo.Tests
{
    /// <summary>
    /// Descripción resumida de PartidaTest
    /// </summary>
    [TestClass]
    public class PartidaTest
    {
        [TestMethod]
        public void Partida_IngresarLetra_SiIngresaUnaLetraValida_DebeBuscarLaLetraEnLaPalabraEInformarSiExiste()
        {
            IPartida partida = new Partida(new Palabra("fernets"),0);
            
            Assert.IsTrue(partida.IngresarLetra("s"));
        }

        [TestMethod]
        public void Partida_IngresarLetra_SiIngresaUnaLetraInvalida_DebeBuscarLaLetraEnLaPalabraEInformarSiExiste()
        {
            IPartida partida = new Partida(new Palabra("fernet"),0);

            Assert.IsFalse(partida.IngresarLetra("s"));
        }

        [TestMethod]
        public void Partida_IngresarLetra_SiIngresaUnEspacio_DebeBuscarLaLetraEnLaPalabraEInformarSiExiste()
        {
            IPartida partida = new Partida(new Palabra("fernet"),0);

            Assert.IsFalse(partida.IngresarLetra(" "));
        }

        [TestMethod]
        public void Partida_IngresarLetra_SiIngresaNull_DebeBuscarLaLetraEnLaPalabraEInformarSiExiste()
        {
            IPartida partida = new Partida(new Palabra("fernet"),0);

            Assert.IsFalse(partida.IngresarLetra(null));
        }

        [TestMethod]
        public void Partida_IngresarLetra_DebeGuardarLaLetraIngresada()
        {
            IPartida partida = new Partida(new Palabra("fernet"),0);

            partida.IngresarLetra("f");

            Assert.AreEqual(partida.LetrasIngresadas.First(), "f");
        }


        [TestMethod]
        public void Partida_IngresarLetras_DebeGuardarLaLetraIngresada()
        {
            IPartida partida = new Partida(new Palabra("fernet"),0);

            partida.IngresarLetra("f");
            partida.IngresarLetra("e");
            partida.IngresarLetra("n");

            Assert.AreEqual(partida.LetrasIngresadas.Count(), 3);
        }


        [TestMethod]
        public void Partida_IngresarLetrasEnColeccion_DebeGuardarVerdadero()
        {
            IPartida partida = new Partida(new Palabra("fernet"),0);
            
            partida.IngresarLetra("e");
            partida.IngresarLetra("n");

            Assert.IsTrue(partida.LetrasIngresadas.Contains("e")) ;
        }

        [TestMethod]
        public void Partida_BuscarLetra_SiNoExiste_DebeIncrementarElContadorDeIntentosFallidos()
        {
            IPartida partida = new Partida(new Palabra("fernet"),0);

            partida.IngresarLetra("x");
            Assert.AreEqual(partida.IntentosFallidos, 1);
        }

        [TestMethod]
        public void Partida_BuscarLetra_SiExiste_NoDebeIncrementarElContadorDeIntentosFallidos()
        {
            IPartida partida = new Partida(new Palabra("fernet"),0);

            partida.IngresarLetra("e");
            Assert.AreEqual(partida.IntentosFallidos, 0);
        }

        [TestMethod]
        public void Partida_PerdioPartida_SuperaMaximoDeIntentos_Pirdepartida()
        {
            IPartida partida = new Partida(new Palabra("fernet"), 0);

            partida.IngresarLetra("z");
            Assert.IsTrue(partida.LlegoAlMaximoDeIntentosFallidos());
        }

        [TestMethod]
        public void Partida_PerdioPartida_NoSuperaMaximoDeIntentos_Pirdepartida()
        {
            IPartida partida = new Partida(new Palabra("fernet"), 1);

            partida.IngresarLetra("e");
            Assert.IsFalse(partida.LlegoAlMaximoDeIntentosFallidos());
        }
    }

}
