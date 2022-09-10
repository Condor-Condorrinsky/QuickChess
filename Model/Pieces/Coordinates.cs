namespace QuickChess.Model.Pieces
{
    public class Coordinates
    {
        public uint Row { get; set; }
        public uint Column { get; set; }

        public Coordinates (uint row, uint column)
        {
            this.Row = row;
            this.Column = column;
        }
    }
}