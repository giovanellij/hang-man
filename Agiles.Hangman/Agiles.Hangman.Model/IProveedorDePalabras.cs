namespace Agiles.Hangman.Model
{
    public interface IProveedorDePalabras
    {
        IPalabra Nueva();
        IPalabra IngresarValor(string valor);
        int Indice();
    }
}
