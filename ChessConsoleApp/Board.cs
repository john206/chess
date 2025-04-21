namespace ChessConsoleApp;

internal class Board
{
    public Board()
    {
        for (int rank = 0; rank < 8; rank++)
        {
            for (int file = 0; file < 8; file++)
            {
                Squares[rank, file] = new Square { Rank = rank, File = file };
            }
        }
    }

    public bool IsFlipped { get; set; } = false;

    public Square[,] Squares { get; } = new Square[8, 8];

    public Square GetSquare(int rank, int file)
    {
        return Squares[rank, file];
    }

    public void FlipBoard()
    {
        IsFlipped = !IsFlipped;
    }

    public void DrawBoard()
    {
        if (!IsFlipped)
        {
            for (int rank = 7; rank >= 0; rank--)
            {
                Console.Write($"{rank + 1} ");
                for (int file = 0; file < 8; file++)
                {
                    var square = Squares[rank, file];
                    Console.Write(square.Piece is not null ? square.Piece.ToString() : " . ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("  a b c d e f g h");
        }
        else
        {
            for (int rank = 0; rank < 8; rank++)
            {
                Console.Write($"{rank + 1} ");
                for (int file = 7; file >= 0; file--)
                {
                    var square = Squares[rank, file];
                    Console.Write(square.Piece is not null ? square.Piece.ToString() : " . ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("  h g f e d c b a");
        }
    }
}