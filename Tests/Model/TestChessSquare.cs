using NUnit.Framework;
using QuickChess.Model;
using QuickChess.Model.Pieces;

namespace QuickChess.Tests.Model
{
    [TestFixture]
    public class TestChessSquare
    {
        [Test]
        public void TestIsOccupied()
        {
            PieceFactory pf = new PieceFactory();

            ChessSquare occupied = new ChessSquare(pf.GetNewBlackBishop());
            ChessSquare unoccupied = new ChessSquare(pf.GetEmptyPiece());

            Assert.True(occupied.IsOccupied());
            Assert.False(unoccupied.IsOccupied());
        }
    }
}