using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_02_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your age");
            int age = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Your age is : " + age);
            if (age>=18)
            {
                Console.WriteLine("Welcome to the program");
            }
            else if(age<=17)
            {
                Console.WriteLine("You are not old enough");
            }

            Console.ReadLine();
        }
    }
}
