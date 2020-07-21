using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_02_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string faction = string.Empty;
            string race = string.Empty;
            string classType = string.Empty;
            string gender = string.Empty;

            //asking the user  pick faction a faction out of two.
            Console.WriteLine("Choose ur faction");
            Console.WriteLine("1.Shadhon\n2.Shenar");

            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    faction = "Bonno";
                    break;

                case 2:
                    faction = "Cival";
                    break;
            }

            Console.Clear();
            //asking the player to choose race
            Console.WriteLine("Pick your race");
            Console.WriteLine("1.Shadonn\n2.Shenar");

             input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    race = "Shadhon";
                    break;
                case 2:
                    race = "Shenar";
                    break;
            }
            Console.Clear();

        }
    }
}
