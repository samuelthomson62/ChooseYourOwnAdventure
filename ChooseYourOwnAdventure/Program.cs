using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, answer1, weapon;
            bool loop = true;

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name + " pick a weapon");
            Console.WriteLine("1) Sword");
            Console.WriteLine("2) Sheild");
            Console.WriteLine("3) a Flower");
            Console.WriteLine("4) Magic Wand");

            while (loop == true)
            {
                answer1 = Console.ReadLine();

                if (answer1 == "1" || answer1 == "1)")
                {
                    weapon = "Sword";
                    Console.WriteLine("So your name is " + name + " and you weild a " + weapon + ".");
                    loop = false;
                }
                else if (answer1 == "2" || answer1 == "2)")
                {
                    weapon = "Sheild";
                    Console.WriteLine("So your name is " + name + " and you weild a " + weapon + ".");
                    loop = false;
                }
                else if (answer1 == "3" || answer1 == "3)")
                {
                    weapon = "Flower";
                    Console.WriteLine("So your name is " + name + " and you weild a " + weapon + ".");
                    loop = false;
                }
                else if (answer1 == "4" || answer1 == "4)")
                {
                    weapon = "Magic Wand";
                    Console.WriteLine("So your name is " + name + " and you weild a " + weapon + ".");
                    loop = false;
                }
                else
                {
                    Console.WriteLine("Invaled answer. Please try again.");
                }
            }
            Console.WriteLine("This should be interesting. I look forward to seeing how your quest plays out.");
            Console.ReadKey();
        }
    }
}
