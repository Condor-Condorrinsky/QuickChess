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
            PieceFactory pf = new PieceFactory();

            BoardPiece bishop = pf.GetNewBlackBishop();
            BoardPiece king = pf.GetNewBlackKing();
            BoardPiece queen = pf.GetNewBlackQueen();

            chessBoard.PutPiece(0, 1, bishop);
            chessBoard.PutPiece(5, 7, king);
            chessBoard.PutPiece(5, 3, queen);

            Assert.AreEqual(chessBoard.GetPiece(0, 1).FullName, bishop.FullName);
            Assert.AreEqual(chessBoard.GetPiece(5, 7).FullName, king.FullName);
            Assert.AreEqual(chessBoard.GetPiece(5, 3).FullName, queen.FullName);

            chessBoard.PrintBoard();
        }
    }
}