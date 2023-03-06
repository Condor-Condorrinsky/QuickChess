namespace QuickChess.Model.Pieces
{
    public class Coordinates
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public Coordinates (int row, int column)
        {
            if (row < 0 || column < 0) throw new ArgumentOutOfRangeException("Coordinate values cannot be negative");

            this.Row = row;
            this.Column = column;
        }

        public override bool Equals(object? obj)
        {
            Coordinates coords;

            if (obj == null) return false;

            if (!(obj is Coordinates)) return false;
            else coords = (Coordinates) obj;

            if (Row != coords.Row) return false;
            if (Column != coords.Column) return false;

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

                hash = hash * STACK_OVERFLOW_MAGIC_NUMBER2 + Row.GetHashCode();
                hash = hash * STACK_OVERFLOW_MAGIC_NUMBER2 + Column.GetHashCode();

                return hash;
            }
        }

    }
}