namespace QuickChess.Model.Pieces
{
    public class PieceFactory
    {
        public PieceFactory () {}

        public BoardPiece GetDefaultPiece ()
        {
            return new BoardPiece(FullNamesOfPieces.NONE, ShortNamesOfPieces.NONE, Colour.NONE);
        }

        public BoardPiece GetNewBlackKing ()
        {
            return new BoardPiece(FullNamesOfPieces.KING, ShortNamesOfPieces.KING, Colour.BLACK);
        }

        public BoardPiece GetNewWhiteKing ()
        {
            return new BoardPiece(FullNamesOfPieces.KING, ShortNamesOfPieces.KING, Colour.WHITE);
        }

        public BoardPiece GetNewBlackQueen ()
        {
            return new BoardPiece(FullNamesOfPieces.QUEEN, ShortNamesOfPieces.QUEEN, Colour.BLACK);
        }

        public BoardPiece GetNewWhiteQueen ()
        {
            return new BoardPiece(FullNamesOfPieces.QUEEN, ShortNamesOfPieces.QUEEN, Colour.WHITE);
        }

        public BoardPiece GetNewBlackRook ()
        {
            return new BoardPiece(FullNamesOfPieces.ROOK, ShortNamesOfPieces.ROOK, Colour.BLACK);
        }

        public BoardPiece GetNewWhiteRook ()
        {
            return new BoardPiece(FullNamesOfPieces.ROOK, ShortNamesOfPieces.ROOK, Colour.WHITE);
        }

        public BoardPiece GetNewBlackBishop ()
        {
            return new BoardPiece(FullNamesOfPieces.BISHOP, ShortNamesOfPieces.BISHOP, Colour.BLACK);
        }

        public BoardPiece GetNewWhiteBishop ()
        {
            return new BoardPiece(FullNamesOfPieces.BISHOP, ShortNamesOfPieces.BISHOP, Colour.WHITE);
        }

        public BoardPiece GetNewBlackKnight ()
        {
            return new BoardPiece(FullNamesOfPieces.KNIGHT, ShortNamesOfPieces.KNIGHT, Colour.BLACK);
        }

        public BoardPiece GetNewWhiteKnight ()
        {
            return new BoardPiece(FullNamesOfPieces.KNIGHT, ShortNamesOfPieces.KNIGHT, Colour.WHITE);
        }

        public BoardPiece GetNewBlackPawn ()
        {
            return new BoardPiece(FullNamesOfPieces.PAWN, ShortNamesOfPieces.PAWN, Colour.BLACK);
        }

        public BoardPiece GetNewWhitePawn ()
        {
            return new BoardPiece(FullNamesOfPieces.PAWN, ShortNamesOfPieces.PAWN, Colour.WHITE);
        }
    }
}