

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main()
        {
            Board tablero = new Board(); // Genero el tablero
            tablero.First(); // Guardo el primer tablero
            ConsolePrinter printer = new ConsolePrinter(); // Creo el printer
            printer.PrintBoard(tablero); 
            while (true)
            {
                tablero.Change(); // Siguiente generacion
                printer.PrintBoard(tablero); // Printeo la siguiente generacion
            }
        }
    }
}
