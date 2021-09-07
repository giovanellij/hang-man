using System.Collections.Generic;

namespace Agiles2017.Ahorcado.Modelo
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
