using Agiles.Hangman.Model.Entities;
using System.Collections.Generic;

namespace Agiles.Hangman.Model.Interfaces
{
    public interface IPalabra
    {
        string Valor { get; }

        List<Letra> Letras { get; }

        bool BuscarLetra(string letra );

        bool EstaCompleta();

        bool Arriesgar(string palabraCompleta);
    }
}
