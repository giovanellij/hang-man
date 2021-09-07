using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agiles2017.Ahorcado.Modelo
{
    public  class Letra
    {
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
