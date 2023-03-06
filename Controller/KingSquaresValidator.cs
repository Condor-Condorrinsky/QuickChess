using QuickChess.Model;
using QuickChess.Model.Pieces;

namespace QuickChess.Controller
{
    /* A dedicated class that checks, which squares are controlled by enemy pieces
       and thus, which squares are unavailable for the king piece */
    public class KingSquaresValidator
    {
        private ChessSquare[,] Grid { get; set; }
        private Dictionary<Coordinates, BoardPiece> piecesInGame { get; set; }

        public KingSquaresValidator (ChessSquare[,] grid, Dictionary<Coordinates, BoardPiece> pieces)
        {
            this.Grid = grid;
            this.piecesInGame = pieces;
        }
    }
}