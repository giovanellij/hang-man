namespace Agiles.Hangman.Model.Entities
{
    public  class Letra
    {
        public Letra()
        {

        }
        public Letra(char valor, int posicion)
        {
            Valor = valor.ToString();
            Posicion = posicion;
        }

        public bool Adivinada { get; set; }
        public string Valor { get; set; }
        public int Posicion { get; set; }
    }
}
