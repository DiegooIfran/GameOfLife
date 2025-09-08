namespace Program;

public class Board
{
    public Cell[,] Cells  {get; private set;}
    private BoardImporter importer;
    private Cell[,] _initial; 

    public Board(Cell[,] initialBoard)
    {
        this.Cells = initialBoard;
        importer = new BoardImporter();
        _initial = importer.GetBoard();
        
    }

    public int GetBoardLength(int indice)
    {
        int length = this.Cells.GetLength(indice);
        return length;
    }
    
    public Board Update(Board board)
    {
        Motor nuevo = new Motor();
        Board boardActualizado = nuevo.Generate(board);
        return boardActualizado;
    }
}