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

            if ((from.Row == to.Row) && (from.Column == to.Column)) return false;
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
            // Knights move in an "L" pattern: they always change their row by 2 and column by 1 or vice versa
            const int KNIGHTS_MOVE_RANGE_ONE = 1;
            const int KNIGHTS_MOVE_RANGE_TWO = 2;

            if ((Math.Abs(to.Row - from.Row) == KNIGHTS_MOVE_RANGE_ONE) &&
                (Math.Abs(to.Column - from.Column) == KNIGHTS_MOVE_RANGE_TWO)) return true;
            if ((Math.Abs(to.Row - from.Row) == KNIGHTS_MOVE_RANGE_TWO) &&
                (Math.Abs(to.Column - from.Column) == KNIGHTS_MOVE_RANGE_ONE)) return true;

            return false;
        }

        public bool ValidatePawnMove(Coordinates from, Coordinates to, Colour cl)
        {
            const int WHITE_PAWN_STARTING_ROW = 6;
            const int WHITE_PAWN_ROW_AFTER_DOUBLE_STEP = 4;
            const int BLACK_PAWN_STARTING_ROW = 1;
            const int BLACK_PAWN_ROW_AFTER_DOUBLE_STEP = 3;
            const int PAWN_MOVE_RANGE = 1;

            switch (cl)
            {
                case Colour.WHITE:
                    // Double hop when pawn is on its initial square
                    if (from.Row == WHITE_PAWN_STARTING_ROW && to.Row == WHITE_PAWN_ROW_AFTER_DOUBLE_STEP &&
                        from.Column == to.Column) return true;
                    // Normal move forward
                    if (from.Row - PAWN_MOVE_RANGE == to.Row && from.Column == to.Column) return true;
                    // Taking piece diagonally to the left of pawn
                    if (from.Row - PAWN_MOVE_RANGE == to.Row && from.Column - PAWN_MOVE_RANGE == to.Column &&
                        Grid[to.Row, to.Column].IsOccupied() && Grid[to.Row, to.Column].Piece.Colour == Colour.BLACK)
                        return true;
                    // Taking piece to the right of pawn
                    if (from.Row - PAWN_MOVE_RANGE == to.Row && from.Column + PAWN_MOVE_RANGE == to.Column &&
                        Grid[to.Row, to.Column].IsOccupied() && Grid[to.Row, to.Column].Piece.Colour == Colour.BLACK)
                        return true;
                    break;
                case Colour.BLACK:
                    // Double hop when pawn is on its initial square
                    if (from.Row == BLACK_PAWN_STARTING_ROW && to.Row == BLACK_PAWN_ROW_AFTER_DOUBLE_STEP &&
                        from.Column == to.Column) return true;
                    // Normal move forward
                    if (from.Row + PAWN_MOVE_RANGE == to.Row && from.Column == to.Column) return true;
                    // Taking piece diagonally to the left of pawn
                    if (from.Row + PAWN_MOVE_RANGE == to.Row && from.Column + PAWN_MOVE_RANGE == to.Column &&
                        Grid[to.Row, to.Column].IsOccupied() && Grid[to.Row, to.Column].Piece.Colour == Colour.WHITE)
                        return true;
                    // Taking piece diagonally to the right of pawn
                    if (from.Row + PAWN_MOVE_RANGE == to.Row && from.Column - PAWN_MOVE_RANGE == to.Column &&
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