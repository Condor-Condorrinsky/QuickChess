namespace QuickChess.Model.Pieces
{
    public class Coordinates
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public Coordinates (int row, int column)
        {
            if (row < 0 || column < 0) throw new ArgumentException("Coordinate values cannot be negative");

            this.Row = row;
            this.Column = column;
        }
    }
}