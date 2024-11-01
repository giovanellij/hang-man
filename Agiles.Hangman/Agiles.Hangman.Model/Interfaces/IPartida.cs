﻿using System.Collections.Generic;

namespace Agiles.Hangman.Model.Interfaces
{
    public interface IPartida
    {
        IPalabra Palabra { get; }

        int IntentosFallidos { get; }

        int MaximoDeIntentos { get; }

        List<string> LetrasIngresadas { get; }

        bool IngresarLetra(string letra);

        bool Arriesgar(string palabraCompleta);

        bool LlegoAlMaximoDeIntentosFallidos();
    }
}
