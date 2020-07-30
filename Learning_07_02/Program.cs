using System;

namespace Learning_07_01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Theory

            //if animal hungry they eat or they don't
            //if animal is full of energy they don't sleep if no energy they sleep
            Console.WriteLine("please Pick and animal: 1 for tiger, 2 for fish, 3 for bird");

            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    TigerActions();
                    break;
                case 2:
                    FishActions();
                    break;
                case 3:
                    BirdActions();
                    break;
            }

            #endregion Theory
        }

        private static void TigerActions()
        {
            Tiger tiger = new Tiger();
            Console.WriteLine("You have chosen tiger! Wise choice");

            while (true)
            {
                Console.WriteLine("Pick an action, 1: Eat , 2:sleep , 3:Jump");

                int input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    tiger.Eat();
                }
                else if (input == 2)
                {
                    tiger.Sleep();
                }
                else if (input == 3)
                {
                    tiger.Jump();
                }

                tiger.Status();
                Console.WriteLine("Please try again");
                Console.ReadLine();
                Console.Clear();
            }
        }

        private static void BirdActions()
        {
            Bird bird = new Bird();
            Console.WriteLine("You have chosen bird! Smart choice");

            while (true)
            {
                Console.WriteLine("Pick an action, 1: Eat , 2:sleep , 3:Fly");

                int input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    bird.Eat();
                }
                else if (input == 2)
                {
                    bird.Sleep();
                }
                else if (input == 3)
                {
                    bird.Fly();
                }

                bird.Status();
                Console.WriteLine("Please try again");
                Console.ReadLine();
                Console.Clear();
            }
        }

        private static void FishActions()
        {
            Fish fish = new Fish();
            Console.WriteLine("You have chosen tiger! Wise choice");

            while (true)
            {
                Console.WriteLine("Pick an action, 1: Eat , 2:sleep , 3:Swim");

                int input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    fish.Eat();
                }
                else if (input == 2)
                {
                    fish.Sleep();
                }
                else if (input == 3)
                {
                    fish.Swim();
                }

                fish.Status();
                Console.WriteLine("Please try again");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}