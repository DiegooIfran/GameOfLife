using System;
using System.Text;
using System.Threading;

namespace Program;

public class ConsolePrinter
{
    public void PrintBoard(Board gameBoard)
    {
        Console.Clear();
        StringBuilder s = new StringBuilder();
        for (int y = 0; y < gameBoard.GetBoardLength(0); y++)
        {
            for (int x = 0; x < gameBoard.GetBoardLength(1); x++)
            {
                if (gameBoard.Cells[x, y].Alive)
                {
                    s.Append("|:)|");
                }
                else
                {
                    s.Append("____");
                }
            }

            s.Append("\n");
        }

        Console.WriteLine(s.ToString());
        Thread.Sleep(300);
    }
}