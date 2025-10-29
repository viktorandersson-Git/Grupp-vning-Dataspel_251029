using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppövning_Dataspel_251029
{
    internal class Game
    {

        public string GameName { get; set; } = "Unknown game";

        public Game(string gameName)
        {
            GameName = gameName;
        }

        //public void PlayGame()
        //{
        //    Console.WriteLine("Välkommen! Jag tänker på ett nummer mellan 0 - 20. " +
        //        "Kan du gissa vilket? Du får fem försök.");

        //    int randomNumber = Random.Shared.Next(0, 21);

        //    int guesses = 5;

        //    bool correctNumber = false;

        //    while (guesses > 0 && !correctNumber)

        //    {
        //        int userNumber = int.Parse(Console.ReadLine());
        //        guesses = guesses - 1;

        //        if (randomNumber == userNumber)
        //        {
        //            correctNumber = true;
        //            Console.WriteLine("Grattis! Du vann!");
        //        }
        //        else if (userNumber > randomNumber)
        //        {
        //            Console.WriteLine("Tyvärr, för högt.");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Tyvärr, för lågt.");
        //        }
        //    }
        //    if (!correctNumber)
        //    {
        //        Console.WriteLine($"Tyvärr, rätt nummer var {randomNumber}");
        //    }
        //}



        //levels
        // vann du spelet? ja nej? level up
        // name
    }
}
