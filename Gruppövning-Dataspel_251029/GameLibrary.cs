using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppövning_Dataspel_251029
{
    internal class GameLibrary 
    {
      

        List<Game> library = new List<Game>();
        //skapa metod för addera spel

        public void AddGameToLibrary(Game game)
        {
            library.Add(game);
        }

        public void RemoveGameFromLibrary(Game game)
        {
            Console.WriteLine("Vilket spel vill du avinstallera");
            string userCoice = Console.ReadLine();
            if(userCoice == game.GameName)
            library.Remove(game);
            Console.WriteLine("");
        }
        public void ShowGameLibrary()
        {
            foreach (var game in library)
            {
                Console.WriteLine(game);
            }
        }

    }
}
