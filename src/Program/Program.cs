

using Program;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {   
        static void Main()
        {
            BoardImporter first = new BoardImporter();
            Board tablero = new Board(first.GetBoard()); // Genero el tablero
            ConsolePrinter printer = new ConsolePrinter(); // Creo el printer
            printer.PrintBoard(tablero); 
            while (true)
            {
                Motor.Generate(tablero); // Siguiente generacion
                printer.PrintBoard(tablero); // Printeo la siguiente generacion
            }
        }
    }
}
