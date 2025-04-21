namespace ChessConsoleApp;

internal class Queen : Piece
{
    public Queen(PieceColor color)
    {
        Color = color;
        Name = PieceName.Q;
    }

    protected override bool IsMoveValidSpecific(Square target)
    {
        // Implement queen-specific move logic here
        return true;
    }
}