using QuickChess.Model.Pieces;

namespace QuickChess.Model
{
    public class MoveValidator
    {
        public MoveValidator () {}

        // TODO: finish the body
        public bool IsMoveValid()
        {
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
            return false;
        }
    }
}