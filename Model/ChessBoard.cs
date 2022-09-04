using QuickChess.Model.Pieces;
using System.Collections.Generic;
using System;

namespace QuickChess.Model
{
    public class ChessBoard
    {
        public int Size { get; set; }
        public ChessSquare[,] Grid { get; set; }

        public ChessBoard (int size)
        {
            this.Size = size;
            this.Grid = new ChessSquare[size, size];

            for (uint i = 0; i < size; i++)
            {
                for (uint j = 0; j < size; j++)
                {
                    Grid[i, j] = new ChessSquare(i, j, new BoardPiece(FullNamesOfPieces.None, ShortNamesOfPieces.None));
                }
            }
        }

        // Should belong to View but it's a temporary solution
        public void PrintBoard ()
        {
            for (uint i = 0; i < Size; i++)
            {
                for (uint j = 0; j < Size; j++)
                {
                    
                    switch (Grid[i, j].Piece.FullName)
                    {
                        case FullNamesOfPieces.None:
                            PrintSingleSquare(j, ShortNamesOfPieces.None);
                            break;
                        case FullNamesOfPieces.Knight:
                            PrintSingleSquare(j, ShortNamesOfPieces.Knight);
                            break;
                    }
                }
            }
        }

        private void PrintSingleSquare (uint i, char c)
        {
            const int CLASSIC_CHESSBOARD_WIDTH = 8;
            const char COLUMN_SEPARATOR = ' ';

            if ((i + 1) % CLASSIC_CHESSBOARD_WIDTH == 0)
            {
                // Finished priniting row, moving to another.
                Console.Write(c + '\n');
                return;
            }

            Console.Write(c + COLUMN_SEPARATOR);
        }
    }
}