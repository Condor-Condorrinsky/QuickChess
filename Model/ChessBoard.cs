using QuickChess.Model.Pieces;

namespace QuickChess.Model
{
    public class ChessBoard
    {
        public int Size { get; set; }
        public ChessSquare[,] Grid { get; set; }
        private PieceFactory Factory { get; }

        public ChessBoard (int size)
        {
            this.Size = size;
            this.Grid = new ChessSquare[size, size];
            this.Factory = new PieceFactory();

            for (uint i = 0; i < size; i++)
            {
                for (uint j = 0; j < size; j++)
                {
                    // PutPiece(i, j, Factory.GetDefaultPiece());
                    Grid[i, j] = new ChessSquare(i, j, Factory.GetDefaultPiece());
                }
            }
        }

        public BoardPiece GetPiece(uint row, uint column) { return this.Grid[row, column].Piece; }

        public void PutPiece(uint row, uint column, BoardPiece piece) { this.Grid[row, column].Piece = piece; }

        // Should belong to View but it's a temporary solution
        public void PrintBoard ()
        {
            for (uint i = 0; i < Size; i++)
            {
                for (uint j = 0; j < Size; j++)
                {
                    BoardPiece piece = GetPiece(i, j);

                    switch (piece.FullName)
                    {
                        case FullNamesOfPieces.None:
                            PrintSingleSquare(j, ShortNamesOfPieces.None, piece.Colour);
                            break;
                        case FullNamesOfPieces.Pawn:
                            PrintSingleSquare(j, ShortNamesOfPieces.Pawn, piece.Colour);
                            break;
                        case FullNamesOfPieces.Knight:
                            PrintSingleSquare(j, ShortNamesOfPieces.Knight, piece.Colour);
                            break;
                        case FullNamesOfPieces.Bishop:
                            PrintSingleSquare(j, ShortNamesOfPieces.Bishop, piece.Colour);
                            break;
                        case FullNamesOfPieces.Rook:
                            PrintSingleSquare(j, ShortNamesOfPieces.Rook, piece.Colour);
                            break;
                        case FullNamesOfPieces.Queen:
                            PrintSingleSquare(j, ShortNamesOfPieces.Queen, piece.Colour);
                            break;
                        case FullNamesOfPieces.King:
                            PrintSingleSquare(j, ShortNamesOfPieces.King, piece.Colour);
                            break;
                        default:
                            throw new ArgumentException("ChessBoard received different piece than expected.");
                    }
                }
            }
        }

        private void PrintSingleSquare (uint i, char c, Colour colour)
        {
            const char NEWLINE = '\n';
            const char COLUMN_SEPARATOR = ' ';
            char[] chars;
            string toPrint;

            switch (colour)
            {
                case Colour.NONE:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case Colour.WHITE:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case Colour.BLACK:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
            }

            if ((i + 1) % Size == 0)
            {
                // Finished priniting row, moving to another.
                chars = new char [] {c, NEWLINE};
                toPrint = new string(chars);
                Console.Write(toPrint);
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            chars = new char [] {c, COLUMN_SEPARATOR};
            toPrint = new string(chars);
            Console.Write(toPrint);

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}