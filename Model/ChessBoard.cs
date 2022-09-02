namespace QuickChess.Model
{
    public class ChessBoard
    {
        public int Size { get; set; }
        public ChessSquare[,] Grid { get; set; }

        public ChessBoard (int size)
        {
            Size = size;
            Grid = new ChessSquare[size, size];

            for (uint i = 0; i < size; i++)
            {
                for (uint j = 0; j < size; j++)
                {
                    Grid[i, j] = new ChessSquare(i, j);
                }
            }
        }

        // Should belong to View but it's a temporary solution
        public void printBoard ()
        {
            
        }
    }
}