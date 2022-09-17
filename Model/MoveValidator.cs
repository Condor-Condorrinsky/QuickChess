using QuickChess.Model.Pieces;

namespace QuickChess.Model
{
    public class MoveValidator
    {
        public ChessSquare[,] Grid { get; set; }

        public MoveValidator (ChessSquare[,] grid)
        {
            this.Grid = grid;
        }

        // TODO: finish the body
        public bool IsMoveValid()
        {
            return false;
        }

        public bool ValidateKingMove(Coordinates from, Coordinates to)
        {
            const int KINGS_RANGE = 2;

            if (Math.Abs(to.Row - from.Row) < KINGS_RANGE && (Math.Abs(to.Column - from.Column)) < KINGS_RANGE) return true;

            return false;
        }

        public bool ValidateQueenMove(Coordinates from, Coordinates to)
        {
            if (ValidateBishopMove(from, to) || ValidateRookMove(from, to)) return true;

            return false;
        }

        public bool ValidateRookMove(Coordinates from, Coordinates to)
        {
            if ((from.Row == to.Row) && (from.Column != to.Column)) return true;
            if ((from.Row != to.Row) && (from.Column == to.Column)) return true;

            return false;
        }

        public bool ValidateBishopMove(Coordinates from, Coordinates to)
        {
            if ((from.Row == to.Row) && (from.Column == to.Column)) return false;
            if (Math.Abs(to.Row - from.Row) == (Math.Abs(to.Column - from.Column))) return true;

            return false;
        }

        public bool ValidateKnightMove(Coordinates from, Coordinates to)
        {
            if ((Math.Abs(to.Row - from.Row) == 1) && (Math.Abs(to.Column - from.Column) == 2)) return true;
            if ((Math.Abs(to.Row - from.Row) == 2) && (Math.Abs(to.Column - from.Column) == 1)) return true;

            return false;
        }

        // TODO: finish implementation
        public bool ValidatePawnMove(Coordinates from, Coordinates to, Colour cl)
        {
            switch (cl)
            {
                case Colour.WHITE:
                    // Double hop when pawn is on its initial square
                    if (from.Row == 6 && to.Row == 4 && from.Column == to.Column) return true;
                    // Normal move forward
                    if (from.Row - 1 == to.Row && from.Column == to.Column) return true;
                    // Taking piece to the left of pawn
                    if (from.Row - 1 == to.Row && from.Column - 1 == to.Column &&
                        Grid[to.Row, to.Column].IsOccupied() && Grid[to.Row, to.Column].Piece.Colour == Colour.BLACK)
                        return true;
                    // Taking piece to the right of pawn
                    if (from.Row - 1 == to.Row && from.Column + 1 == to.Column &&
                        Grid[to.Row, to.Column].IsOccupied() && Grid[to.Row, to.Column].Piece.Colour == Colour.BLACK)
                        return true;
                    break;
                case Colour.BLACK:
                    // Double hop when pawn is on its initial square
                    if (from.Row == 1 && to.Row == 3 && from.Column == to.Column) return true;
                    // Normal move forward
                    if (from.Row + 1 == to.Row && from.Column == to.Column) return true;
                    // Taking piece to the left of pawn
                    if (from.Row + 1 == to.Row && from.Column + 1 == to.Column &&
                        Grid[to.Row, to.Column].IsOccupied() && Grid[to.Row, to.Column].Piece.Colour == Colour.WHITE)
                        return true;
                    // Taking piece to the right of pawn
                    if (from.Row + 1 == to.Row && from.Column - 1 == to.Column &&
                        Grid[to.Row, to.Column].IsOccupied() && Grid[to.Row, to.Column].Piece.Colour == Colour.WHITE)
                        return true;
                    break;
                default:
                    throw new ArgumentException("Received colour other than BLACK or WHITE");
            }

            return false;
        }
    }
}