using System;

namespace Learning_07_01
{/// <summary>
/// makes the animal eat, sleep and indicate energy level.
/// </summary>
    internal class Animal
    {/// <summary>
     /// describe how energetic and hungry the animal is
     /// </summary>
        protected int hunger;

        protected float energy=10;

        //Protected will expose functionality to all inheriting classes and the owning class
        //Private only exposes functionality to the owning class
        //Public exposes functionality to the whole program

        public int Myhunger
        {
            get
            {
                return hunger;
            }
        }

        public float MyEnergy
        {
            get { return energy; }
        }

        public void Eat()
        {
            if (hunger>0)
            {
                hunger--;
                energy++;
                Console.WriteLine("I'm eating don't disturb me");
            }
            else
            {
                Console.WriteLine("I don't want to eat. I am not hungry");
            }
        }

        public void Sleep()
        {
            if (energy<=5)
            {
                energy++;
                Console.WriteLine("I'm sleeping");
            }
            else
            {
                Console.WriteLine("I am not tired");
            }
        }

        public void Status()
        {
            Console.WriteLine($"My energy is {energy}, my hunger is {hunger}");
        }
    }
}