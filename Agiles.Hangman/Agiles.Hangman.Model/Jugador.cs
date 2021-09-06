namespace Agiles.Hangman.Model
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
