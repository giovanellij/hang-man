using Agiles.Hangman.Model.Entities;
using Agiles.Hangman.Model.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Agiles.Hangman.Tests
{
    [TestClass]
    public class PalabraTest
    {
        [TestMethod]
        public void Palabra_BuscarLetra_CuandoingresaLetraValida_DebeDevolverVerdadero()
        {
            IPalabra palabra = new Palabra("fernet");
           
            Assert.IsTrue(palabra.BuscarLetra("f"));
        }

        [TestMethod]
        public void Palabra_BuscarLetra_CuandoingresaLetraNoValida_DebeDevolverFalso()
        {
            IPalabra palabra = new Palabra("fernet");

            Assert.IsFalse(palabra.BuscarLetra("a"));
        }

        [TestMethod]
        public void Palabra_BuscarLetra_CuandoingresaVacio_DebeDevolverFalso()
        {
            IPalabra palabra = new Palabra("fernet");
            Assert.IsFalse(palabra.BuscarLetra(""));
        }

        [TestMethod]
        public void Palabra_BuscarLetra_CuandoingresaNull_DebeDevolverFalso()
        {
            IPalabra palabra = new Palabra("fernet");
            Assert.IsFalse(palabra.BuscarLetra(null));
        }

        [TestMethod]
        public void Palabra_BuscarLetra_CuandoingresaUnEspacio_DebeDevolverFalso()
        {
            IPalabra palabra = new Palabra("fernet");
            Assert.IsFalse(palabra.BuscarLetra(" "));
        }

        [TestMethod]
        public void Palabra_BuscarLetra_CuandoingresaUnNumero_DebeDevolverFalso()
        {
            IPalabra palabra = new Palabra("fernet");
            Assert.IsFalse(palabra.BuscarLetra("9"));
        }

        [TestMethod]
        public void Palabra_EstaCompleta_CuandoSeAdivinanTodasLasLetras_DebeDevolverVerdadero()
        {
            IPalabra palabra = new Palabra("fernet");

            palabra.BuscarLetra("f");
            palabra.BuscarLetra("e");
            palabra.BuscarLetra("r");
            palabra.BuscarLetra("n");
            palabra.BuscarLetra("t");

            Assert.IsTrue(palabra.EstaCompleta());
        }

        [TestMethod]
        public void Palabra_EstaCompleta_CuandoNoSeAdivinanTodasLasLetras_DebeDevolverFalso()
        {
            IPalabra palabra = new Palabra("fernet");

            palabra.BuscarLetra("f");
            palabra.BuscarLetra("e");
            palabra.BuscarLetra("R");
            palabra.BuscarLetra("t");

            Assert.IsFalse(palabra.EstaCompleta());
        }

        [TestMethod]
        public void Palabra_Arriesgar_CuandoSeAvidinaLaPalabra_DebeDevolverVerdadero()
        {
            IPalabra palabra = new Palabra("fernet");

            palabra.BuscarLetra("f");
            
            Assert.IsTrue(palabra.Arriesgar("fernet"));
        }

        [TestMethod]
        public void Palabra_Arriesgar_CuandoNoSeAvidinaLaPalabra_DebeDevolverFalso()
        {
            IPalabra palabra = new Palabra("fernet");

            palabra.BuscarLetra("f");

            Assert.IsFalse(palabra.Arriesgar("coca"));
        }
    }
}
