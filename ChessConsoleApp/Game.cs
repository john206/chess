namespace ChessConsoleApp;

internal class Game
{
    // CoPilot generated
    
    //private readonly Board _board;
    //private PieceColor _currentTurn;
    //public Game()
    //{
    //    _board = new Board();
    //    _currentTurn = PieceColor.W;
    //}
    //public void Start()
    //{
    //    while (true)
    //    {
    //        Console.Clear();
    //        Console.WriteLine(_board);
    //        Console.WriteLine($"Current turn: {_currentTurn}");
    //        Console.Write("Enter your move (e.g., e2 e4): ");
    //        var input = Console.ReadLine();
    //        if (input == null) continue;
    //        var move = ParseMove(input);
    //        if (move != null && _board.MovePiece(move.Value.Item1, move.Value.Item2, _currentTurn))
    //        {
    //            _currentTurn = _currentTurn == PieceColor.W ? PieceColor.B : PieceColor.W;
    //        }
    //    }
    //}
    //private static (Square, Square)? ParseMove(string input)
    //{
    //    var parts = input.Split(' ');
    //    if (parts.Length != 2) return null;
    //    var origin = Square.Parse(parts[0]);
    //    var target = Square.Parse(parts[1]);
    //    return (origin, target);
    //}
}
