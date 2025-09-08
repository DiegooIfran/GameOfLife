namespace Program
{
    class Program
    {
        static void Main(string[] args)
        { 
            BoardImporter importer = new BoardImporter(); 
            Cell[,] initialBoard = importer.GetBoard();
            
            Board tablero = new Board(initialBoard);
            ConsolePrinter printer = new ConsolePrinter();
            printer.PrintBoard(tablero);
            while (true)
            {
                
                tablero = tablero.Update(tablero);
                printer.PrintBoard(tablero);
            }
        }
    }
}


