namespace QuickChess.Model.Pieces
{
    public class BoardPiece
    {
        public string FullName { get; set; }
        public char ShortName { get; set; }
        public PieceColour Colour { get; set; }

        public BoardPiece (string fullName, char shortName, PieceColour colour)
        {
            this.FullName = fullName;
            this.ShortName = shortName;
            this.Colour = colour;
        }
    }
}