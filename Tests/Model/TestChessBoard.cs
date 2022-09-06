using NUnit.Framework;
using QuickChess.Model;
using QuickChess.Model.Pieces;

namespace QuickChess.Tests.Model
{
    [TestFixture]
    public class TestChessBoard
    {
        const int CLASSIC_CHESSBOARD_SIZE = 8;

        [Test]
        public void TestPrintBoard ()
        {
            ChessBoard chessBoard = new ChessBoard(CLASSIC_CHESSBOARD_SIZE);

            chessBoard.PutPiece(2, 7, new BoardPiece(FullNamesOfPieces.Bishop, ShortNamesOfPieces.Bishop));
            chessBoard.PutPiece(0, 5, new BoardPiece(FullNamesOfPieces.Knight, ShortNamesOfPieces.Knight));
            chessBoard.PutPiece(3, 4, new BoardPiece(FullNamesOfPieces.Queen, ShortNamesOfPieces.Queen));
            chessBoard.PutPiece(7, 0, new BoardPiece(FullNamesOfPieces.King, ShortNamesOfPieces.King));
            chessBoard.PutPiece(4, 4, new BoardPiece(FullNamesOfPieces.Pawn, ShortNamesOfPieces.Pawn));

            Assert.True(chessBoard.Grid[2,7].Piece.Equals(new BoardPiece(FullNamesOfPieces.Bishop, ShortNamesOfPieces.Bishop)));
        }
    }
}