using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Agiles2017.Ahorcado.Modelo.Tests
{
    [TestClass]
    public class ProveedorDePalabrasTest
    {
        [TestMethod]
        public void ProveedorDePalabras_CuandoSeIngresaUnaPalabra_DebeGenerarUnaPalabra()
        {
            IProveedorDePalabras proveedor = new ProveedorDePalabras(null);

            IPalabra palabra = proveedor.IngresarValor("Fernet");

            Assert.AreEqual(palabra.Valor, "FERNET");
        }

        [TestMethod]
        public void ProveedorDePalabras_Nueva_DebeDevolverUnaPalabraDeLaLista()
        {
            List<string> lista = new List<string>();
            lista.Add("casa");
            lista.Add("fernet");
            IProveedorDePalabras proveedor = new ProveedorDePalabras(lista);

            IPalabra palabra = proveedor.Nueva();

            Assert.IsTrue(lista.Contains(palabra.Valor));
        }

        [TestMethod]
        public void ProveedorDePalabras_Indice_DebeVeolverUnNumeroEntreCeroYElMaximoDePalabras()
        {
            List<string> lista = new List<string>();
            lista.Add("casa");
            lista.Add("fernet");
            lista.Add("fernet2");
            IProveedorDePalabras proveedor = new ProveedorDePalabras(lista);

            var indice = proveedor.Indice();

            Assert.IsTrue(indice < lista.Count() && indice >= 0);
        }


    }
}
