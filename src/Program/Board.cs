using Program;

namespace Ucu.Poo.GameOfLife;

public class Board
{
    private Cell[,] board;
    public void First()
    {
        BoardImporter first = new BoardImporter();
        board = first.GetBoard();
    }

    public int GetLength(int i)
    {
        return board.GetLength(i);
    }
    
    public Cell[,] GetCells()
    {
        return board;
    }
    
    public void SetCells(Cell[,] newBoard)
    {
        board = newBoard;
    }
    
    public void Change()
    {
        Motor nuevo = new Motor();
        nuevo.Generate(this);
    }
    
        //=================================================
        //Invocar método para calcular siguiente generación
        //Motor nuevo = new Motor();
        //board = nuevo.generate(board);
        //=================================================
}