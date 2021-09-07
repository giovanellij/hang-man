using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agiles2017.Ahorcado.Modelo
{
    public class Jugador : IJugador
    {
        public Jugador(string nombre)
        {
            Nombre = nombre;
        }

        public string Nombre { get; private set; }
    }
}
