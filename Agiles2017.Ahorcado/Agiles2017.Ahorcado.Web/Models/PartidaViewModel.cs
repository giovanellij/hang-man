using Agiles2017.Ahorcado.Modelo;
using System.Collections.Generic;

namespace Agiles2017.Ahorcado.Web.Models
{
    public class PartidaViewModel
    {
        public PartidaViewModel(IPartida partida)
        {
            EstadoPalabra = new List<Letra>();
            foreach (var item in partida.Palabra.Letras)
            {
                if (item.Adivinada)
                {
                    EstadoPalabra.Add(item);
                }
                else
                {
                    EstadoPalabra.Add(new Letra('_', item.Posicion));
                }
            }
            PalabraCompleta = partida.Palabra.EstaCompleta();

            LetrasIngresadas = partida.LetrasIngresadas;

            IntentosFallidos = partida.IntentosFallidos;

            MaxIntentos = partida.MaximoDeIntentos;

            LlegoAlMaximoDeIntentos = partida.LlegoAlMaximoDeIntentosFallidos();
        }

        public bool PalabraCompleta { get; set; }

        public ICollection<Letra> EstadoPalabra { get; set; }

        public ICollection<string> LetrasIngresadas { get; set; }

        public int IntentosFallidos { get; set; }

        public int MaxIntentos { get; set; }

        public bool LlegoAlMaximoDeIntentos { get; set; }
    }
}