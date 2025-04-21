namespace ChessConsoleApp;

internal class Pawn : Piece
{
    public Pawn(PieceColor color)
    {
        Color = color;
        Name = PieceName.P;
    }

    protected override bool IsMoveValidSpecific(Square target)
    {
        // Implement pawn-specific move logic here
        return true;
    }
}