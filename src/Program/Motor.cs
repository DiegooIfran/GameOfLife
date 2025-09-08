namespace Ucu.Poo.GameOfLife;


public class Motor
{
    public void Generate(Board gameBoard) // Su razon de cambio son las reglas de juego
    {
        Cell[,] actualBoard = gameBoard.GetCells(); // Consigo el array de celulas
        int boardWidth = gameBoard.GetLength(0); // Consigo las longitudes
        int boardHeight = gameBoard.GetLength(1);

        Cell[,] cloneBoard = new Cell[boardWidth, boardHeight];
        for (int x = 0; x < boardWidth; x++)
        {
            for (int y = 0; y < boardHeight; y++)
            {
                int aliveNeighbors = 0;
                for (int i = x - 1; i <= x + 1; i++)
                {
                    for (int j = y - 1; j <= y + 1; j++)
                    {
                        if (i >= 0 && i < boardWidth && j >= 0 && j < boardHeight && actualBoard[i, j].Alive)
                        {
                            aliveNeighbors++;
                        }
                    }
                }

                if (actualBoard[x, y].Alive)
                {
                    aliveNeighbors--;
                }

                if (actualBoard[x, y].Alive && aliveNeighbors < 2)
                {
                    //Celula muere por baja población
                    cloneBoard[x, y] = new Cell();
                    cloneBoard[x, y].Die();
                }
                else if (actualBoard[x, y].Alive && aliveNeighbors > 3)
                {
                    //Celula muere por sobrepoblación
                    cloneBoard[x, y] = new Cell();
                    cloneBoard[x, y].Die();
                }
                else if (!actualBoard[x, y].Alive && aliveNeighbors == 3)
                {
                    //Celula nace por reproducción
                    cloneBoard[x, y] = new Cell();
                    cloneBoard[x, y].Born();
                }
                else
                {
                    //Celula mantiene el estado que tenía
                    cloneBoard[x, y] = actualBoard[x, y];
                }
            }
        }

        gameBoard.SetCells(cloneBoard); // Setteo el gameBoard con el array de celulas de CloneBoard
    }
}