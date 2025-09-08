using System.Dynamic;
using Program;

namespace Ucu.Poo.GameOfLife;

public class Board // Su razon de cambio es como quieras devolver el tablero, en este caso array de celulas.
{
    private Cell[,] _board;
    
    public Board(Cell[,] cells)
    {
        this._board = cells;
    }

    public int GetLength(int i) //Devuelve la longitud del array en el eje deseado
    {
        return _board.GetLength(i);
    }
    
    public Cell[,] GetCells()
    {
        return _board; // Devuelve el array de celulas
    }
    
    public void SetCells(Cell[,] newBoard)
    {
        _board = newBoard; // Settea un array de celulas a un board
    }
    
}