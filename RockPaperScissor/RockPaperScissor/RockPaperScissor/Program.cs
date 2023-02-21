using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Console.WriteLine("Wanna Play Game? (Type 'yes' if you want to play)");
        var answer = Console.ReadLine().ToLower();
        if(answer == "yes") 
        {
            Start.StartGame();
        }
        else
        {
            Console.WriteLine("Good bye!");
        }

    }
}
