public static  class Start
{
    
    public static void StartGame()
        {
            Console.WriteLine("Let's play Rock, Paper, Scissors!");

            Game game = new Game(Outcomes.outcomes);
            while (true)
            {
                Console.Write("Enter your move (rock, paper, or scissors): ");
                string playerMove = Console.ReadLine().ToLower();

                GameResult result = game.Play(playerMove);
                Console.WriteLine(result.Message);
                Console.WriteLine();

                if (result.GameOver)
                {
                    Console.WriteLine("Thanks for playing!");
                    break;
                }
            }
        }

}
