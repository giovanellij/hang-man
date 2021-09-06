using System;
using System.Collections.Generic;
using System.Linq;

namespace Agiles.Hangman.Model
{
    public class Palabra : IPalabra
    {
        private ICollection<Letra> _letras;

        public Palabra(string valor)
        {
            Valor = valor;
            _letras = new List<Letra>();

            CrearLetras();
        }

        public string Valor { get; private set; }

        public ICollection<Letra> Letras { get { return _letras; } }

        public bool BuscarLetra(string letra)
        {
            bool existe = false;

            if(!String.IsNullOrWhiteSpace(letra))
            {
                existe = _letras.Any(l => l.Valor == letra);
                if (existe)
                {
                    _letras.Where(l => l.Valor == letra).ToList().ForEach(x => x.Adivinada = true);
                }
            }
           
            return existe;
        }

        public bool EstaCompleta()
        {
            return !_letras.Any(l => !l.Adivinada);
        }

        public bool Arriesgar(string palabraCompleta)
        {
            foreach (var letra in palabraCompleta.ToCharArray())
            {
                BuscarLetra(letra.ToString());
            }

            return EstaCompleta();
        }

        private void CrearLetras()
        {
            var letras = Valor.ToArray();
            for (int i = 0; i < letras.Count(); i++)
            {
                _letras.Add(new Letra(letras.ElementAt(i), i));
            }
        }
    }
}
