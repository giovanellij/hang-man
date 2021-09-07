using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agiles2017.Ahorcado.Modelo
{
    public interface IProveedorDePalabras
    {
        IPalabra Nueva();
        IPalabra IngresarValor(string valor);
        int Indice();
    }
}
