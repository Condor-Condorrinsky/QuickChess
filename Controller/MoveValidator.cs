using QuickChess.Model;
using QuickChess.Model.Pieces;

namespace QuickChess.Controller
{
    public class MoveValidator
    {
        public ChessSquare[,] Grid { get; set; }

        public MoveValidator (ChessSquare[,] grid)
        {
            this.Grid = grid;
        }

        public bool IsMoveValid(BoardPiece piece, Coordinates from, Coordinates to)
        {
            switch (piece.FullName)
            {
                case "King":
                    return ValidateKingMove(from, to, piece.Colour);
                case "Queen":
                    return ValidateQueenMove(from, to, piece.Colour);
                case "Rook":
                    return ValidateRookMove(from, to , piece.Colour);
                case "Bishop":
                    return ValidateBishopMove(from, to, piece.Colour);
                case "Knight":
                    return ValidateKnightMove(from, to, piece.Colour);
                case "Pawn":
                    return ValidatePawnMove(from, to, piece.Colour);
                default:
                    throw new ArgumentException("Did not receive a valid chess piece as an argument");
            }
        }

        public bool ValidateKingMove(Coordinates from, Coordinates to, Colour cl)
        {
            const int KINGS_RANGE = 2;

            // Square occupied by friendly piece
            if (IsSquareOccupied(to) && CheckPieceColour(to) == cl) return false;

            if ((from.Row == to.Row) && (from.Column == to.Column)) return false;
            if (Math.Abs(to.Row - from.Row) < KINGS_RANGE && (Math.Abs(to.Column - from.Column)) < KINGS_RANGE) return true;

            return false;
        }

        public bool ValidateQueenMove(Coordinates from, Coordinates to, Colour cl)
        {
            return (ValidateBishopMove(from, to, cl) || ValidateRookMove(from, to, cl));
        }

        public bool ValidateRookMove(Coordinates from, Coordinates to, Colour cl)
        {
            int GetLowerBound(int first, int second) => first < second ? first : second;
            int GetUpperBound(int first, int second) => first > second ? first : second;

            // Square occupied by friendly piece
            if (IsSquareOccupied(to) && CheckPieceColour(to) == cl) return false;

            // Are any squares along the way occupied?
            if ((from.Row == to.Row) && (from.Column != to.Column))
            {
                int lower = GetLowerBound(from.Column, to.Column) + 1;
                int upper = GetUpperBound(from.Column, to.Column);

                for (int i = lower; i < upper; i++)
                {
                    if (IsSquareOccupied(new Coordinates(to.Row, i))) return false;
                }

                return true;
            }
            if ((from.Row != to.Row) && (from.Column == to.Column))
            {
                int lower = GetLowerBound(from.Row, to.Row) + 1;
                int upper = GetUpperBound(from.Row, to.Row);

                for (int i = lower; i < upper; i++)
                {
                    if (IsSquareOccupied(new Coordinates(i, to.Column))) return false;
                }

                return true;
            }

            return false;
        }

        public bool ValidateBishopMove(Coordinates from, Coordinates to, Colour cl)
        {
            // Square occupied by friendly piece
            if (IsSquareOccupied(to) && CheckPieceColour(to) == cl) return false;
            // No change of position
            if ((from.Row == to.Row) && (from.Column == to.Column)) return false;

            // Are any squares along the way occupied?
            if (Math.Abs(to.Row - from.Row) == (Math.Abs(to.Column - from.Column)))
            {
                int bound = Math.Abs(to.Row - from.Row);
                int rowChange = Math.Sign(from.Row - to.Row);
                int columnChange = Math.Sign(from.Column - to.Column);

                for (int i = 1; i < bound; i++)
                {
                    if (rowChange > 0 && columnChange > 0)
                    {
                        Coordinates test = new Coordinates(from.Row + i, from.Column + i);
                        if (IsSquareOccupied(test)) return false;
                    }
                    else if (rowChange > 0 && columnChange < 0)
                    {
                        Coordinates test = new Coordinates(from.Row + i, from.Column - i);
                        if (IsSquareOccupied(test)) return false;
                    }
                    else if (rowChange < 0 && columnChange > 0)
                    {
                        Coordinates test = new Coordinates(from.Row - i, from.Column + i);
                        if (IsSquareOccupied(test)) return false;
                    }
                    else if (rowChange < 0 && columnChange < 0)
                    {
                        Coordinates test = new Coordinates(from.Row - i, from.Column - i);
                        if (IsSquareOccupied(test)) return false;
                    }
                    else throw new ArithmeticException("Somehow the \"if\" has failed me");
                }

                return true;
            }

            return false;
        }

        public bool ValidateKnightMove(Coordinates from, Coordinates to, Colour cl)
        {
            // Knights move in an "L" pattern: they always change their row by 2 and column by 1 or vice versa
            const int KNIGHTS_MOVE_RANGE_ONE = 1;
            const int KNIGHTS_MOVE_RANGE_TWO = 2;

            // Square occupied by friendly piece
            if (IsSquareOccupied(to) && CheckPieceColour(to) == cl) return false;

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

            // Square occupied by friendly piece
            if (IsSquareOccupied(to) && CheckPieceColour(to) == cl) return false;

            switch (cl)
            {
                case Colour.WHITE:
                    // Double hop when pawn is on its initial square
                    if (from.Row == WHITE_PAWN_STARTING_ROW && to.Row == WHITE_PAWN_ROW_AFTER_DOUBLE_STEP &&
                        from.Column == to.Column &&
                        // Is the square you're hoping over occupied?
                        !IsSquareOccupied(new Coordinates(to.Row - PAWN_MOVE_RANGE, to.Column)) &&
                        // Is the destination square occupied?
                        !IsSquareOccupied(to))
                        return true;
                    // Normal move forward
                    if (from.Row - PAWN_MOVE_RANGE == to.Row && from.Column == to.Column &&
                        !IsSquareOccupied(to))
                        return true;
                    // Taking piece diagonally to the left of pawn
                    if (from.Row - PAWN_MOVE_RANGE == to.Row && from.Column - PAWN_MOVE_RANGE == to.Column &&
                        IsSquareOccupied(to) && CheckPieceColour(to) == Colour.BLACK)
                        return true;
                    // Taking piece to the right of pawn
                    if (from.Row - PAWN_MOVE_RANGE == to.Row && from.Column + PAWN_MOVE_RANGE == to.Column &&
                        IsSquareOccupied(to) && CheckPieceColour(to) == Colour.BLACK)
                        return true;
                    break;
                case Colour.BLACK:
                    // Double hop when pawn is on its initial square
                    if (from.Row == BLACK_PAWN_STARTING_ROW && to.Row == BLACK_PAWN_ROW_AFTER_DOUBLE_STEP &&
                        from.Column == to.Column &&
                        // Is the square you're hoping over occupied?
                        !IsSquareOccupied(new Coordinates(to.Row + PAWN_MOVE_RANGE, to.Column)) &&
                        // Is the destination square occupied?
                        !IsSquareOccupied(to))
                        return true;
                    // Normal move forward
                    if (from.Row + PAWN_MOVE_RANGE == to.Row && from.Column == to.Column &&
                        !IsSquareOccupied(to))
                        return true;
                    // Taking piece diagonally to the left of pawn
                    if (from.Row + PAWN_MOVE_RANGE == to.Row && from.Column + PAWN_MOVE_RANGE == to.Column &&
                        IsSquareOccupied(to) && CheckPieceColour(to) == Colour.WHITE)
                        return true;
                    // Taking piece diagonally to the right of pawn
                    if (from.Row + PAWN_MOVE_RANGE == to.Row && from.Column - PAWN_MOVE_RANGE == to.Column &&
                        IsSquareOccupied(to) && CheckPieceColour(to) == Colour.WHITE)
                        return true;
                    break;
                default:
                    throw new ArgumentException("Received colour other than BLACK or WHITE");
            }

            return false;
        }

        private bool IsSquareOccupied(Coordinates coords)
        {
            return (Grid[coords.Row, coords.Column].IsOccupied());
        }

        private Colour CheckPieceColour(Coordinates coords)
        {
            return Grid[coords.Row, coords.Column].Piece.Colour;
        }
    }
}