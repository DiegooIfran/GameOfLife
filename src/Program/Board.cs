using Program;

namespace Ucu.Poo.GameOfLife;

public class Board
{
    private Cell[,] board = BoardImporter();
    
    public Cell[,] Change(Cell[,] board)
    {
        Motor nuevo = new Motor();
        return nuevo.Generate(board);
    }
        //=================================================
        //Invocar método para calcular siguiente generación
        //Motor nuevo = new Motor();
        //board = nuevo.generate(board);
        //=================================================
}