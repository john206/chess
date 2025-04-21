namespace ChessConsoleApp;

internal enum PieceColor
{
    W,
    B
}

internal enum PieceName
{
    P,
    R,
    N,
    B,
    Q,
    K
}

internal abstract class Piece
{
    public required PieceColor Color { get; init; }

    public required PieceName Name { get; init; }

    public bool Move(Square origin, Square target)
    {
        if (origin.Piece is null || !IsMoveValid(target))
        {
            return false;
        }

        origin.Piece = null;
        target.Piece = this;
        return true;        
    }    

    public override string ToString()
    {
        return $"{Color}-{Name}";
    }
    
    // Rules for valid moves that are specific to each piece type
    protected abstract bool IsMoveValidSpecific(Square target);

    // Rules for valid moves that apply to all pieces
    private bool IsMoveValidShared(Square target)
    {
        return IsMoveWithinBounds(target) && target.Piece?.Color != Color;
    }

    private bool IsMoveValid(Square target)
    {
        return IsMoveValidShared(target) && IsMoveValidSpecific(target);
    }

    private static bool IsMoveWithinBounds(Square target)
    {
        return target.Rank >= 0 && target.Rank < 8 && target.File >= 0 && target.File < 8;
    }
}