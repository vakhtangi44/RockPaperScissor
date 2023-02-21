class GameResult
{
    public string Message { get; }
    public bool GameOver { get; }

    public GameResult(string message, bool gameOver = false)
    {
        Message = message;
        GameOver = gameOver;
    }
}
