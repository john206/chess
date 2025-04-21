namespace ChessConsoleApp;

internal class Bishop : Piece
{
    public Bishop(PieceColor color)
    {
        Color = color;
        Name = PieceName.B;
    }

    protected override bool IsMoveValidSpecific(Square target)
    {
        // Implement bishop-specific move logic here
        return true;
    }
}