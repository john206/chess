namespace ChessConsoleApp;

internal class Knight : Piece
{
    public Knight(PieceColor color)
    {
        Color = color;
        Name = PieceName.N;
    }

    protected override bool IsMoveValidSpecific(Square target)
    {
        // Implement knight-specific move logic here
        return true;
    }
}