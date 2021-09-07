using Newtonsoft.Json;
using System.Collections.Generic;

namespace Agiles.Hangman.Model
{
    public class Partida : IPartida
    {
        public Partida()
        {

        }

        public Partida(IPalabra palabra, int maximoDeIntentos)
        {
            Palabra = palabra;
            LetrasIngresadas = new List<string>();
            MaximoDeIntentos = maximoDeIntentos;
        }

        public int IntentosFallidos { get; set; }

        public int MaximoDeIntentos { get; set; }

        public List<string> LetrasIngresadas { get; set; }

        [JsonConverter(typeof(ConcreteTypeConverter<Palabra>))]
        public IPalabra Palabra { get; set; }

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
