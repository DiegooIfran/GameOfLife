using System;
using Program;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Board tablero = new Board();
            tablero.First();
            ConsolePrinter printer = new ConsolePrinter();
            printer.PrintBoard(tablero);
            while (true)
            {
                tablero.Change();
                printer.PrintBoard(tablero);
            }

        }
    }
}
