namespace ChessConsoleApp;

internal class Rook : Piece
{
    public Rook(PieceColor color)
    {
        Color = color;
        Name = PieceName.R;
    }

    protected override bool IsMoveValidSpecific(Square target)
    {
        // Implement rook-specific move logic here
        return true;
    }
}