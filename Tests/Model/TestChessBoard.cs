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
        public void TestPutPiece ()
        {
            ChessBoard chessBoard = new ChessBoard(CLASSIC_CHESSBOARD_SIZE);

            BoardPiece bishop = new BoardPiece(FullNamesOfPieces.Bishop, ShortNamesOfPieces.Bishop);
            BoardPiece king = new BoardPiece(FullNamesOfPieces.King, ShortNamesOfPieces.King);
            BoardPiece queen = new BoardPiece(FullNamesOfPieces.Queen, ShortNamesOfPieces.Queen);

            chessBoard.PutPiece(0, 1, bishop);
            chessBoard.PutPiece(5, 7, king);
            chessBoard.PutPiece(5, 3, queen);

            Assert.AreEqual(chessBoard.Grid[0,1].Piece.FullName, bishop.FullName);
            Assert.AreEqual(chessBoard.Grid[5,7].Piece.FullName, king.FullName);
            Assert.AreEqual(chessBoard.Grid[5,3].Piece.FullName, queen.FullName);
        }
    }
}