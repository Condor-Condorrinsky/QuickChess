namespace QuickChess.Model.Pieces
{
    public class Knight : BoardPiece
    {
        public ChessSquare CurrSquare { get; set; }

        public Knight (ChessSquare square)
        {
            CurrSquare = square;
        }

        public override void MakeMove (int currRow, int currColumn)
        {

        }
    }
}