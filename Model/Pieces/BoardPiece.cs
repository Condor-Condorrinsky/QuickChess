namespace QuickChess.Model.Pieces
{
    public class BoardPiece
    {
        public string FullName { get; }
        public char ShortName { get; }
        public Colour Colour { get; }

        public BoardPiece (string fullName, char shortName, Colour colour)
        {
            this.FullName = fullName;
            this.ShortName = shortName;
            this.Colour = colour;
        }

        public override bool Equals(object? obj)
        {
            BoardPiece piece;

            if (obj == null) return false;

            if (!(obj is BoardPiece)) return false;
            else piece = (BoardPiece) obj;

            if (FullName != piece.FullName) return false;
            if (ShortName != piece.ShortName) return false;
            if (Colour != piece.Colour) return false;

            return true;
        }

        public override int GetHashCode()
        {
            //https://stackoverflow.com/questions/263400/what-is-the-best-algorithm-for-overriding-gethashcode
            const int STACK_OVERFLOW_MAGIC_NUMBER1 = 17;
            const int STACK_OVERFLOW_MAGIC_NUMBER2 = 23;

            unchecked
            {
                int hash = STACK_OVERFLOW_MAGIC_NUMBER1;

                hash = hash * STACK_OVERFLOW_MAGIC_NUMBER2 + FullName.GetHashCode();
                hash = hash * STACK_OVERFLOW_MAGIC_NUMBER2 + ShortName.GetHashCode();
                // Colour might be equal to 0 with high probability.
                hash = hash * STACK_OVERFLOW_MAGIC_NUMBER2 + (Colour.GetHashCode() + 1);

                return hash;
            }
        }
    }
}