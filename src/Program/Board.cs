using Program;

namespace Ucu.Poo.GameOfLife;

public class Board
{
    private Cell[,] board = new Cell[,];
    public Cell[,] First()
    {
        return BoardImporter.GetBoard();
    }

    public int GetLength(int i)
    {
        return bo.GetLength(i);
    }
    
    public void Change(Cell[,] boar)
    {
        Motor nuevo = new Motor();
        boar = nuevo.Generate(boar);
    }
        //=================================================
        //Invocar método para calcular siguiente generación
        //Motor nuevo = new Motor();
        //board = nuevo.generate(board);
        //=================================================
}