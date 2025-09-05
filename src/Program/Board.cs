using System.Dynamic;
using Program;

namespace Ucu.Poo.GameOfLife;

public class Board
{
    public Cell[,] Cells  {get; private set;}
    private BoardImporter importer = new BoardImporter();
    private Cell[,] initial = importer.GetBoard();

    public Board(Cell[,] initialBoard)
    {
        this.Cells = initialBoard;
    }
    /*
    public Cell[,] First()
    {
        return imported;
    }
    */
    public Board boardVacio()
    {
        int boardWidth = initial.GetLength(0);
        int boardHeight = initial.GetLength(1);

        Board[,] cloneboard = new Board[boardWidth, boardHeight];
        return cloneboard;
    }
    
    public void Update(Cell[,] gameBoard)
    {
        Motor nuevo = new Motor();
        gameBoard = nuevo.Generate(this.Cells);
    }
        //=================================================
        //Invocar método para calcular siguiente generación
        //Motor nuevo = new Motor();
        //board = nuevo.generate(board);
        //=================================================
}