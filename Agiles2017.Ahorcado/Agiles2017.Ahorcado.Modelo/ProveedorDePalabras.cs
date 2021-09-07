using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agiles2017.Ahorcado.Modelo
{
    public class ProveedorDePalabras : IProveedorDePalabras
    {
        private Random _random;
        private ICollection<string> _palabras;

        public ProveedorDePalabras(ICollection<string> listaDePalabras)
        {
            _palabras = listaDePalabras;
            _random = new Random(0);
        }

        public IPalabra IngresarValor(string valor)
        {
            return new Palabra(valor.ToUpper());
        }

        public IPalabra Nueva()
        {
            return new Palabra(_palabras.ElementAt(Indice()));
        }

        public int Indice()
        {
            var a = _random.Next(_palabras.Count());
            if (a == 0)
            { return 0; }

            else
            {
                return a - 1;
            }
        }
    }
}
