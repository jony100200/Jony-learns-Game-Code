using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_07_01
{/// <summary>
/// makes the bird fly
/// </summary>
    class Bird: Animal
    {
        public void Fly()
        {
            if (energy>0 && hunger<5)
            {
                hunger++;
                energy--;
                Console.WriteLine("I'm flying");
            }else if (hunger>=5)
            {
                Console.WriteLine("I don't want to do that.I am hungry");
            }else if (energy == 0)
            {
                Console.WriteLine("I don't have energy");
            }
        }
    }
}
