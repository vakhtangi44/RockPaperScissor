class Game
{
    private readonly Dictionary<string, string> _outcomes;
    private int _playerScore;
    private int _computerScore;

    public Game(Dictionary<string, string> outcomes)
    {
        _outcomes = outcomes;
    }

    public Game(Dictionary<Configuration, Configuration> outcomes)
    {
    }

    public GameResult Play(string playerMove)
    {
        if (!_outcomes.ContainsKey(playerMove))
        {
            return new GameResult("Invalid move. Please try again.");
        }

        string computerMove = GetComputerMove();

        string message = $"You chose {playerMove}, and the computer chose {computerMove}.";

        if (playerMove == computerMove)
        {
            message += " It's a draw!";
        }
        else if (_outcomes[playerMove] == computerMove)
        {
            message += " You win!";
            _playerScore++;
            
        }
        else
        {
            message += " You lose.";
            _computerScore++;
        }

        var isGameOver = _playerScore == 3 || _computerScore == 3;

        if (isGameOver)
        {
            if (_playerScore == 3)
            {
                message += " You win the game!";
            }
            else if (_computerScore == 3)
            {
                message += " You lose the game!";
            }
        }

        return new GameResult(message, isGameOver);
    }

    private string GetComputerMove()
    {
        Random random = new Random();
        string[] moves = { "rock", "paper", "scissors" };
        return moves[random.Next(moves.Length)];
    }
}
