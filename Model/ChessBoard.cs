using QuickChess.Model.Pieces;

namespace QuickChess.Model
{
    public class ChessBoard
    {
        public int Size { get; set; }
        public ChessSquare[,] Grid { get; set; }
        private PieceSpawner Spawner { get; }

        public ChessBoard (int size)
        {
            this.Size = size;
            this.Grid = new ChessSquare[size, size];
            this.Spawner = new PieceSpawner();

            for (uint i = 0; i < size; i++)
            {
                for (uint j = 0; j < size; j++)
                {
                    PutPiece(i, j, Spawner.GetDefaultPiece());
                }
            }
        }

        public BoardPiece GetPiece(uint row, uint column)
        {
            return this.Grid[row, column].Piece;
        }

        public void PutPiece(uint row, uint column, BoardPiece piece)
        {
            this.Grid[row, column].Piece = piece;
        }

        // Should belong to View but it's a temporary solution
        public void PrintBoard ()
        {
            for (uint i = 0; i < Size; i++)
            {
                for (uint j = 0; j < Size; j++)
                {
                    BoardPiece piece = GetPiece(i, j);

                    switch (GetPiece(i, j).FullName)
                    {
                        case FullNamesOfPieces.None:
                            PrintSingleSquare(j, ShortNamesOfPieces.None);
                            break;
                        case FullNamesOfPieces.Pawn:
                            PrintSingleSquare(j, ShortNamesOfPieces.Pawn);
                            break;
                        case FullNamesOfPieces.Knight:
                            PrintSingleSquare(j, ShortNamesOfPieces.Knight);
                            break;
                        case FullNamesOfPieces.Bishop:
                            PrintSingleSquare(j, ShortNamesOfPieces.Bishop);
                            break;
                        case FullNamesOfPieces.Rook:
                            PrintSingleSquare(j, ShortNamesOfPieces.Rook);
                            break;
                        case FullNamesOfPieces.Queen:
                            PrintSingleSquare(j, ShortNamesOfPieces.Queen);
                            break;
                        case FullNamesOfPieces.King:
                            PrintSingleSquare(j, ShortNamesOfPieces.King);
                            break;
                        default:
                            throw new ArgumentException("ChessBoard received different piece than expected.");
                    }
                }
            }
        }

        private void PrintSingleSquare (uint i, char c)
        {
            const char NEWLINE = '\n';
            const char COLUMN_SEPARATOR = ' ';

            if ((i + 1) % Size == 0)
            {
                // Finished priniting row, moving to another.
                Console.Write(c + NEWLINE);
                return;
            }

            Console.Write(c + COLUMN_SEPARATOR);
        }
    }
}