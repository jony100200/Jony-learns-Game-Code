using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_02_00
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Gender: \n Male, Female");

            string command = Console.ReadLine();

            if (command=="Male")
            {
                Console.WriteLine("Hello Sir");
            }else if (command == "Female") 
            {
                Console.WriteLine("Hello Madame");
            }
            Console.ReadLine();
        }
    }
}
