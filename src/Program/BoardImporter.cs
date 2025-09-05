using System.IO;
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
            string content = File.ReadAllText(_url);
            _contentLines = content.Split('\n');

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