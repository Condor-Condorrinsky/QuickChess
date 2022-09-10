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

            string dummyObject = "dummy";
            var whiteKing = pf.GetNewWhiteKing();
            var blackKnight = pf.GetNewBlackKnight();
            var anotherWhiteKnight = pf.GetNewWhiteKnight();

            Assert.False(whiteKnight.Equals(null));
            // Frankly, I have ABSOLUTELY NO IDEA why compiler thinks there might be a null reference here,
            // so I just used the null-forgiving operator
            Assert.False(whiteKnight!.Equals(dummyObject));
            Assert.False(whiteKnight.Equals(whiteKing));
            Assert.False(whiteKnight.Equals(blackKnight));
            Assert.True(whiteKnight.Equals(anotherWhiteKnight));
        }
    }
}