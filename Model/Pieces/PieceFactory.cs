namespace QuickChess.Model.Pieces
{
    public class PieceFactory
    {
        public PieceFactory () {}

        public BoardPiece GetDefaultPiece ()
        {
            return new BoardPiece(FullNamesOfPieces.None, ShortNamesOfPieces.None, Colour.NONE);
        }

        public BoardPiece GetNewBlackKing ()
        {
            return new BoardPiece(FullNamesOfPieces.King, ShortNamesOfPieces.King, Colour.BLACK);
        }

        public BoardPiece GetNewWhiteKing ()
        {
            return new BoardPiece(FullNamesOfPieces.King, ShortNamesOfPieces.King, Colour.WHITE);
        }

        public BoardPiece GetNewBlackQueen ()
        {
            return new BoardPiece(FullNamesOfPieces.Queen, ShortNamesOfPieces.Queen, Colour.BLACK);
        }

        public BoardPiece GetNewWhiteQueen ()
        {
            return new BoardPiece(FullNamesOfPieces.Queen, ShortNamesOfPieces.Queen, Colour.WHITE);
        }

        public BoardPiece GetNewBlackRook ()
        {
            return new BoardPiece(FullNamesOfPieces.Rook, ShortNamesOfPieces.Rook, Colour.BLACK);
        }

        public BoardPiece GetNewWhiteRook ()
        {
            return new BoardPiece(FullNamesOfPieces.Rook, ShortNamesOfPieces.Rook, Colour.WHITE);
        }

        public BoardPiece GetNewBlackBishop ()
        {
            return new BoardPiece(FullNamesOfPieces.Bishop, ShortNamesOfPieces.Bishop, Colour.BLACK);
        }

        public BoardPiece GetNewWhiteBishop ()
        {
            return new BoardPiece(FullNamesOfPieces.Bishop, ShortNamesOfPieces.Bishop, Colour.WHITE);
        }

        public BoardPiece GetNewBlackKnight ()
        {
            return new BoardPiece(FullNamesOfPieces.Knight, ShortNamesOfPieces.Knight, Colour.BLACK);
        }

        public BoardPiece GetNewWhiteKnight ()
        {
            return new BoardPiece(FullNamesOfPieces.Knight, ShortNamesOfPieces.Knight, Colour.WHITE);
        }

        public BoardPiece GetNewBlackPawn ()
        {
            return new BoardPiece(FullNamesOfPieces.Pawn, ShortNamesOfPieces.Pawn, Colour.BLACK);
        }

        public BoardPiece GetNewWhitePawn ()
        {
            return new BoardPiece(FullNamesOfPieces.Pawn, ShortNamesOfPieces.Pawn, Colour.WHITE);
        }
    }
}