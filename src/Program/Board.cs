using Program;

namespace Ucu.Poo.GameOfLife;

public class Board
{
    private Cell[,] board = BoardImporter();

    public int GetLength(int i)
    {
        return board.GetLength(i);
    }
    
    public void Change(Cell[,] board)
    {
        Motor nuevo = new Motor();
        nuevo.Generate(board);
    }
        //=================================================
        //Invocar método para calcular siguiente generación
        //Motor nuevo = new Motor();
        //board = nuevo.generate(board);
        //=================================================
}