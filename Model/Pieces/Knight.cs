namespace QuickChess.Model.Pieces
{
    public class Knight : BoardPiece
    {
        private const string KNIGHT_NAME = "Knight";

        public Knight () : base()
        {
            this.Name = KNIGHT_NAME;
        }

        public Knight (ChessSquare currentSquare) : base()
        {
            this.CurrSquare = currentSquare;
            this.Name = KNIGHT_NAME;
        }
    }
}