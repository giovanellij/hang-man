using Agiles.Hangman.Model.Interfaces;

namespace Agiles.Hangman.Model.Entities
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
