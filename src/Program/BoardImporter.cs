using System.IO;

namespace Program

{
    public class BoardImporter
    {
        private string _url = "board.txt";
        private string[] _contentLines;
        private bool[,] _board;

        public BoardImporter()
        {
            // para leer archivo
            string content = File.ReadAllText(_url);
            _contentLines = content.Split('\n');

            // inicializar tablero
            _board = new bool[_contentLines.Length, _contentLines[0].Length];

            for (int y = 0; y < _contentLines.Length; y++)
            {
                for (int x = 0; x < _contentLines[y].Length; x++)
                {
                    if (_contentLines[y][x] == '1')
                    {
                        _board[y, x] = true;
                    }
                }
            }
        }

        public bool[,] GetBoard()
        {
            return _board;
        }
    }
}