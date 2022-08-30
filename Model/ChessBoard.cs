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

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Grid[i, j] = new ChessSquare(i, j);
                }
            }
        }
    }
}