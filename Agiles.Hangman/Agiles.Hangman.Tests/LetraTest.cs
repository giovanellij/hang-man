using Agiles.Hangman.Model.Entities;
using Agiles.Hangman.Model.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Agiles.Hangman.Tests
{
    [TestClass]
    public class LetraTest
    {
        [TestMethod]
        public void Letra_CuandoSeCrea_DebeNoEstarAdivinada()
        {
            Letra l = new Letra('a', 1);

            Assert.IsFalse(l.Adivinada);
        }
    }
}
