namespace Program;


public class Motor
{
    public Board Generate(Board gameBoard)
    {
        int boardWidth = gameBoard.GetBoardLength(0);
        int boardHeight = gameBoard.GetBoardLength(1);

        Cell[,] newCells = new Cell[boardWidth, boardHeight];
        for (int x = 0; x < boardHeight; x++)
        {
            for (int y = 0; y < boardWidth; y++)
            {
                newCells[x, y] = new Cell(); // Crear nuevas instancias de Cell
            }
        }
        Board cloneboard = new Board(newCells);
        for (int x = 0; x < boardWidth; x++)
        {
            for (int y = 0; y < boardHeight; y++)
            {
                int aliveNeighbors = 0;
                for (int i = x - 1; i <= x + 1; i++)
                {
                    for (int j = y - 1; j <= y + 1; j++)
                    {
                        if (i >= 0 && i < boardWidth && j >= 0 && j < boardHeight && gameBoard.Cells[i, j].Alive)
                        {
                            aliveNeighbors++;
                        }
                    }
                }
                if (gameBoard.Cells[x, y].Alive)
                {
                    aliveNeighbors--;
                }
                if (gameBoard.Cells[x, y].Alive && aliveNeighbors < 2)
                {
                    //Celula muere por baja población
                    cloneboard.Cells[x, y].Die();
                }
                else if (gameBoard.Cells[x, y].Alive && aliveNeighbors > 3)
                {
                    //Celula muere por sobrepoblación
                    cloneboard.Cells[x, y].Die();
                }
                else if (!gameBoard.Cells[x, y].Alive && aliveNeighbors == 3)
                {
                    //Celula nace por reproducción
                    cloneboard.Cells[x, y].Born();
                }
                else
                {
                    //Celula mantiene el estado que tenía
                    cloneboard.Cells[x, y].Alive = gameBoard.Cells[x, y].Alive;
                }
            }
        }
        return cloneboard;
    }
}