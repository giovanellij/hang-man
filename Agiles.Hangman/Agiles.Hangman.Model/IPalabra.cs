using System.Collections.Generic;

namespace Agiles.Hangman.Model
{
    public interface IPalabra
    {
        string Valor { get; }

        ICollection<Letra> Letras { get; }

        bool BuscarLetra(string letra );

        bool EstaCompleta();

        bool Arriesgar(string palabraCompleta);
    }
}
