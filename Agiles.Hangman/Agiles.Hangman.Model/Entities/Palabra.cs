using System;
using System.Collections.Generic;
using Agiles.Hangman.Model.Interfaces;
using System.Linq;

namespace Agiles.Hangman.Model.Entities
{
    public class Palabra : IPalabra
    {

        public Palabra()
        {
            Letras = new List<Letra>();
        }

        public Palabra(string valor)
        {
            Valor = valor;
            Letras = new List<Letra>();

            CrearLetras();
        }

        public string Valor { get; set; }

        public List<Letra> Letras { get; set; }

        public bool BuscarLetra(string letra)
        {
            bool existe = false;

            if(!String.IsNullOrWhiteSpace(letra))
            {
                existe = Letras.Any(l => l.Valor == letra);
                if (existe)
                {
                    Letras.Where(l => l.Valor == letra).ToList().ForEach(x => x.Adivinada = true);
                }
            }
           
            return existe;
        }

        public bool EstaCompleta()
        {
            return !Letras.Any(l => !l.Adivinada);
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
                Letras.Add(new Letra(letras.ElementAt(i), i));
            }
        }
    }
}
