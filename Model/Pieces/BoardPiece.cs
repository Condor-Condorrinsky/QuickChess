namespace QuickChess.Model.Pieces
{
    public abstract class BoardPiece
    {
        private const string DEFAULT_NAME = "DefaultName";

        public ChessSquare? CurrSquare { get; set; }
        public string Name { get; protected set; }

        public BoardPiece ()
        {
            this.CurrSquare = null;
            this.Name = DEFAULT_NAME;
        }

        public BoardPiece (ChessSquare currentSquare)
        {
            CurrSquare = currentSquare;
            Name = DEFAULT_NAME;
        }
    }
}