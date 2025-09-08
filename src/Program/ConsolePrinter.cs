using System;
using System.Text;
using System.Threading;

namespace Ucu.Poo.GameOfLife;

public class ConsolePrinter // Su razon de cambio es el formato de impresion
{
    private Cell[,] _b; // Variable que representa el tablero
    private int _width; // Variabe que representa el ancho del tablero
    private int _height; // Variabe que representa altura del tablero
    
    public void PrintBoard(Board board)
    {
        _b = board.GetCells(); // Consigo el array de celulas
        _width = board.GetLength(1); // Consigo las longitudes
        _height = board.GetLength(0);
        Console.Clear();
        StringBuilder s = new StringBuilder(); // Creo el string que representara el tablero
        for (int y = 0; y < _height; y++)
        {
            for (int x = 0; x < _width; x++)
            {
                if (_b[y, x].Alive)
                {
                    s.Append("|X|");
                }
                else
                {
                    s.Append("___");
                }
            }

            s.Append("\n");
        }

        Console.WriteLine(s.ToString());
        Thread.Sleep(300);
    }
}