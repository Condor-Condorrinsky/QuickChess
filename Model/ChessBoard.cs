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

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    // PutPiece(i, j, Factory.GetDefaultPiece());
                    Grid[i, j] = new ChessSquare(i, j, Factory.GetDefaultPiece());
                }
            }
        }

        public BoardPiece GetPiece(int row, int column)
        {
            if (row < 0 || column < 0 || row > (Size-1) || column > (Size-1)) throw new IndexOutOfRangeException();

            return this.Grid[row, column].Piece;
        }

        public BoardPiece GetPiece(Coordinates coords)
        {
            return this.Grid[coords.Row, coords.Column].Piece;
        }

        public void PutPiece(int row, int column, BoardPiece piece)
        {
            if (row < 0 || column < 0 || row > (Size-1) || column > (Size-1)) throw new IndexOutOfRangeException();

            this.Grid[row, column].Piece = piece;
        }

        public void PutPiece(Coordinates coords, BoardPiece piece)
        {
            this.Grid[coords.Row, coords.Column].Piece = piece;
        }

        public void MakeMove()
        {
            
        }

        // Should belong to View but it's a temporary solution
        public void PrintBoard ()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    BoardPiece piece = GetPiece(i, j);

                    switch (piece.FullName)
                    {
                        case FullNamesOfPieces.NONE:
                            PrintSingleSquare(j, ShortNamesOfPieces.NONE, piece.Colour);
                            break;
                        case FullNamesOfPieces.PAWN:
                            PrintSingleSquare(j, ShortNamesOfPieces.PAWN, piece.Colour);
                            break;
                        case FullNamesOfPieces.KNIGHT:
                            PrintSingleSquare(j, ShortNamesOfPieces.KNIGHT, piece.Colour);
                            break;
                        case FullNamesOfPieces.BISHOP:
                            PrintSingleSquare(j, ShortNamesOfPieces.BISHOP, piece.Colour);
                            break;
                        case FullNamesOfPieces.ROOK:
                            PrintSingleSquare(j, ShortNamesOfPieces.ROOK, piece.Colour);
                            break;
                        case FullNamesOfPieces.QUEEN:
                            PrintSingleSquare(j, ShortNamesOfPieces.QUEEN, piece.Colour);
                            break;
                        case FullNamesOfPieces.KING:
                            PrintSingleSquare(j, ShortNamesOfPieces.KING, piece.Colour);
                            break;
                        default:
                            throw new ArgumentException("ChessBoard received different piece than expected.");
                    }
                }
            }
        }

        private void PrintSingleSquare (int i, char c, Colour colour)
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