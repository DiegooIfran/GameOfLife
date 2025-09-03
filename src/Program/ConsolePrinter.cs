using System;
using System.Text;
using System.Threading;

namespace Ucu.Poo.GameOfLife;

public class ConsolePrinter
{
    private bool[,] b; //variable que representa el tablero
    private int width; //variabe que representa el ancho del tablero
    private int height; //variabe que representa altura del tablero
    
    public void PrintBoard()
    {
        Console.Clear();
        StringBuilder s = new StringBuilder();
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if (b[x, y])
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
        //=================================================
        //Invocar método para calcular siguiente generación
        //=================================================
        Thread.Sleep(300);
    }
}