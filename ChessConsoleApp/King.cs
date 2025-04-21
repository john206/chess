namespace ChessConsoleApp;

internal class King : Piece
{
    public King(PieceColor color)
    {
        Color = color;
        Name = PieceName.K;
    }

    protected override bool IsMoveValidSpecific(Square target)
    {
        // Implement king-specific move logic here
        return true;
    }
}