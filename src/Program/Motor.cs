namespace Ucu.Poo.GameOfLife;


public class Motor
{
    public void Generate(board gameBoard)
    {
        int boardWidth = gameBoard.GetLength(0);
        int boardHeight = gameBoard.GetLength(1);

        Cell[,] cloneboard = new Cell[boardWidth, boardHeight];
        for (int x = 0; x < boardWidth; x++)
        {
            for (int y = 0; y < boardHeight; y++)
            {
                int aliveNeighbors = 0;
                for (int i = x - 1; i <= x + 1; i++)
                {
                    for (int j = y - 1; j <= y + 1; j++)
                    {
                        if (i >= 0 && i < boardWidth && j >= 0 && j < boardHeight && gameBoard[i, j].Alive)//COMO CORNO ACCEDO AL ALIVE DE LA CELULA DE UNA POSICION ESPECIFICA DEL TABLERO
                        {
                            aliveNeighbors++;
                        }
                    }
                }

                if (gameBoard[x, y])
                {
                    aliveNeighbors--;
                }

                if (gameBoard[x, y].Alive && aliveNeighbors < 2)
                {
                    //Celula muere por baja población
                    cloneboard[x, y] = gameBoard[x, y].Die;
                }
                else if (gameBoard[x, y].Alive && aliveNeighbors > 3)
                {
                    //Celula muere por sobrepoblación
                    cloneboard[x, y] =  gameBoard[x, y].Die;
                }
                else if (!gameBoard[x, y].Alive && aliveNeighbors == 3)
                {
                    //Celula nace por reproducción
                    cloneboard[x, y] = gameBoard[x, y].Alive;
                }
                else
                {
                    //Celula mantiene el estado que tenía
                    cloneboard[x, y] = gameBoard[x, y];
                }
            }
        }

        gameBoard = cloneboard;
    }
}