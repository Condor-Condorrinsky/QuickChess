namespace QuickChess.Model.Pieces
{
    public class PieceSpawner
    {
        public PieceSpawner () {}

        public BoardPiece GetDefaultPiece ()
        {
            return new BoardPiece(FullNamesOfPieces.None, ShortNamesOfPieces.None, PieceColour.NONE);
        }

        public BoardPiece GetNewBlackKing ()
        {
            return new BoardPiece(FullNamesOfPieces.King, ShortNamesOfPieces.King, PieceColour.BLACK);
        }

        public BoardPiece GetNewWhiteKing ()
        {
            return new BoardPiece(FullNamesOfPieces.King, ShortNamesOfPieces.King, PieceColour.WHITE);
        }

        public BoardPiece GetNewBlackQueen ()
        {
            return new BoardPiece(FullNamesOfPieces.Queen, ShortNamesOfPieces.Queen, PieceColour.BLACK);
        }

        public BoardPiece GetNewWhiteQueen ()
        {
            return new BoardPiece(FullNamesOfPieces.Queen, ShortNamesOfPieces.Queen, PieceColour.WHITE);
        }

        public BoardPiece GetNewBlackRook ()
        {
            return new BoardPiece(FullNamesOfPieces.Rook, ShortNamesOfPieces.Rook, PieceColour.BLACK);
        }

        public BoardPiece GetNewWhiteRook ()
        {
            return new BoardPiece(FullNamesOfPieces.Rook, ShortNamesOfPieces.Rook, PieceColour.WHITE);
        }

        public BoardPiece GetNewBlackBishop ()
        {
            return new BoardPiece(FullNamesOfPieces.Bishop, ShortNamesOfPieces.Bishop, PieceColour.BLACK);
        }

        public BoardPiece GetNewWhiteBishop ()
        {
            return new BoardPiece(FullNamesOfPieces.Bishop, ShortNamesOfPieces.Bishop, PieceColour.WHITE);
        }

        public BoardPiece GetNewBlackKnight ()
        {
            return new BoardPiece(FullNamesOfPieces.Knight, ShortNamesOfPieces.Knight, PieceColour.BLACK);
        }

        public BoardPiece GetNewWhiteKnight ()
        {
            return new BoardPiece(FullNamesOfPieces.Knight, ShortNamesOfPieces.Knight, PieceColour.WHITE);
        }

        public BoardPiece GetNewBlackPawn ()
        {
            return new BoardPiece(FullNamesOfPieces.Pawn, ShortNamesOfPieces.Pawn, PieceColour.BLACK);
        }

        public BoardPiece GetNewWhitePawn ()
        {
            return new BoardPiece(FullNamesOfPieces.Pawn, ShortNamesOfPieces.Pawn, PieceColour.WHITE);
        }
    }
}