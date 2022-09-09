using NUnit.Framework;
using QuickChess.Model;
using QuickChess.Model.Pieces;

namespace QuickChess.Tests.Model
{
    [TestFixture]
    public class TestBoardPiece
    {
        [Test]
        public void TestEquals()
        {
            PieceFactory pf = new PieceFactory();
            BoardPiece whiteKnight = pf.GetNewWhiteKnight();

            var dummyObject = "dummy";
            var whiteKing = pf.GetNewWhiteKing();
            var blackKnight = pf.GetNewBlackKnight();
            var anotherWhiteKnight = pf.GetNewWhiteKnight();

            Assert.False(whiteKnight.Equals(null));
            Assert.False(whiteKnight.Equals(dummyObject));
            Assert.False(whiteKnight.Equals(whiteKing));
            Assert.False(whiteKnight.Equals(blackKnight));
            Assert.True(whiteKnight.Equals(anotherWhiteKnight));
        }
    }
}