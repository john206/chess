namespace ChessConsoleApp;

internal class Square
{
    public Piece? Piece { get; set; }

    public int Rank { get; init; }

    public int File { get; init; }
}