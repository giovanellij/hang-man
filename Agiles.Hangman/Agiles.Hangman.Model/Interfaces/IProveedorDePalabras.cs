namespace Agiles.Hangman.Model.Interfaces
{
    public interface IProveedorDePalabras
    {
        IPalabra Nueva();
        IPalabra IngresarValor(string valor);
        int Indice();
    }
}
