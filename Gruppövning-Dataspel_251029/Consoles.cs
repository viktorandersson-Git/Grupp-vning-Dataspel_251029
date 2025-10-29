using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppövning_Dataspel_251029
{
    internal class Consoles
    {
        //ska läsa library och initiera spel
        public string Name { get; set; }
        public bool IsOn { get; set; }
        public string Game { get; set; }
        public bool GameStarted { get; set}

        public Consoles(string name, string game)
        {
            Name = name;
            IsOn = false;
            Game = "";
        }

        public void PowerOn()
        {
            IsOn = true;
            Console.WriteLine($"{Name} is now turned on.");
        }
        public void PowerOff()
        {
            IsOn = false;
            Console.WriteLine($"{Name} is now turned off.");
        }

        public void StartGame()
        {
            GameStarted = true;
        }

        if (Consoles.IsOn)
        {

        }

}
}
