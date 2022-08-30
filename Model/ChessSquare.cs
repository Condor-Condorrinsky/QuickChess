namespace QuickChess.Model
{
    public class ChessSquare
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public bool IsOccupied { get; set; }

        public ChessSquare (int row, int column)
        {
            Row = row;
            Column = column;
            IsOccupied = false;
        }
    }
}