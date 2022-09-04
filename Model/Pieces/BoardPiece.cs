namespace QuickChess.Model.Pieces
{
    public class BoardPiece
    {
        public string FullName { get; set; }
        public char ShortName { get; set; }

        public BoardPiece (string fullName, char shortName)
        {
            this.FullName = fullName;
            this.ShortName = shortName;
        }
    }
}