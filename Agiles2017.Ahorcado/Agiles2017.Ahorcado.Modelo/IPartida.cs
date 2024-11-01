﻿using System.Collections.Generic;

namespace Agiles2017.Ahorcado.Modelo
{
    public interface IPartida
    {
        IPalabra Palabra { get; }

        int IntentosFallidos { get; }

        int MaximoDeIntentos { get; }

        ICollection<string> LetrasIngresadas { get; }

        bool IngresarLetra(string letra);

        bool Arriesgar(string palabraCompleta);

        bool LlegoAlMaximoDeIntentosFallidos();
    }
}
