using System.IO;
using System.Linq;
using Ucu.Poo.GameOfLife;

namespace Program

{
    public class BoardImporter
    {
        private string _url = "board.txt";
        private string[] _contentLines;
        public Cell[,] _board;

        public BoardImporter()
        {
            // para leer archivo
            //string content = File.ReadAllText(_url);
            //_contentLines = content.Split('\n');
            _contentLines = File.ReadAllText(_url)
                .Split('\n')
                .Select(l => l.Trim())   // elimina espacios y \r
                .Where(l => l.Length > 0) // elimina líneas vacías
                .ToArray();

            
            // inicializar tablero
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
            return _board;
        }
    }
}