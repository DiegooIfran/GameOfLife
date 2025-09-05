namespace Ucu.Poo.GameOfLife;

public class Board
{
    private bool[,] board = Filereader();

    public bool[,] Change(bool[,] board)
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