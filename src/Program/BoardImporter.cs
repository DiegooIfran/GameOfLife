using System.IO;
using System.Linq;
using Ucu.Poo.GameOfLife;

namespace Program

{
    public class BoardImporter // Su razon de cambio es la forma de recibir el archivo 
    {
        private string _url = "board.txt";
        private string[] _contentLines;
        public Cell[,] _board;

        public BoardImporter()
        {
            _contentLines = File.ReadAllText(_url)
                .Split('\n')
                .Select(l => l.Trim())   // Elimina espacios y \r
                .Where(l => l.Length > 0) // Elimina líneas vacías
                .ToArray(); // Solucion brindada por chatgpt a OutOfRange
            
            // Inicializar tablero
            _board = new Cell[_contentLines.Length, _contentLines[0].Length];

            for (int y = 0; y < _contentLines.Length; y++)
            {
                for (int x = 0; x < _contentLines[y].Length; x++)
                {
                    _board[y, x] = new Cell();
                    if (_contentLines[y][x] == '1')
                    {
                        _board[y, x].Born();
                    }
                }
            }
        }

        public Cell[,] GetBoard()
        {
            return _board; // Devuelve el primer tablero
        }
    }
}