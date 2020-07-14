using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_02_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random= new Random();
            int num1 = random.Next(1, 11);
            int num2 = random.Next(1, 11);

            Console.WriteLine($"First random number is : {num1}");
            Console.WriteLine($"First random number is : {num2}");

            if (num1==2 || num1==4 || num1 == 6 || num1 == 8 || num1 == 10)
            {
                Console.WriteLine("The first number is even");
            }else /*if*/ /*(num1 == 1 || num1 == 3 || num1 == 5 || num1 == 7 || num1 == 9)*/
            {
                Console.WriteLine("The first number is odd");
            }
            if (num2 == 2 || num2 == 4 || num2 == 6 || num2 == 8 || num2 == 10)
            {
                Console.WriteLine("The first number is even");
            }
            else
            {
                Console.WriteLine("The second number is odd");
            }

            Console.ReadLine();
        }
    }
}
