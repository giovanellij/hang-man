using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agiles2017.Ahorcado.Modelo
{
    public class Partida : IPartida
    {
        public Partida(IPalabra palabra, int maximoDeIntentos)
        {
            Palabra = palabra;
            LetrasIngresadas = new List<string>();
            MaximoDeIntentos = maximoDeIntentos;
        }

        public int IntentosFallidos { get; private set; }

        public int MaximoDeIntentos { get; private set; }

        public ICollection<string> LetrasIngresadas { get; private set; }
        
        public IPalabra Palabra { get; private set; }

        public bool IngresarLetra(string letra)
        {
            bool existe = false;
            if (!LetrasIngresadas.Contains(letra))
            {
                LetrasIngresadas.Add(letra);

                existe = Palabra.BuscarLetra(letra);

                if (!existe) { IntentosFallidos++; }
            }

            return existe;
        }

        public bool Arriesgar(string palabraCompleta)
        {
            return Palabra.Arriesgar(palabraCompleta);
        }

        public bool LlegoAlMaximoDeIntentosFallidos()
        {
            return IntentosFallidos >= MaximoDeIntentos;
        }
    }

}
