using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_02_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int hp = 100;

            Console.WriteLine("Enter amount of damage to deal: ");
            int damage = int.Parse(Console.ReadLine());
            Console.WriteLine("Enemy dealing: {0} damage: ", damage);
            hp -= damage;
            if (hp>=100)
            {
                Console.WriteLine("You have full health ");
            }
            else if (hp<100 && hp>=75)
            {
                Console.WriteLine("You have almost full health");
            }else if (hp<75 && hp>=50)
            {
                Console.WriteLine("You have medium health");
            }else if (hp<50 && hp>=25)
            {
                Console.WriteLine("You have low health");
            }
            else if (hp<25 && hp>=1)
            {
                Console.WriteLine("Your health is at critical condition");
            }
            else if (hp<=0)
            {
                Console.WriteLine("You are dead");
            }

            Console.ReadLine();
        }

    }
}
