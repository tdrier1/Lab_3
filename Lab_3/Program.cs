using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            bool run = true;

            Console.WriteLine("Learn you squares and cubes!");
            Console.WriteLine("\n ");

            do
            {
                
                Console.Write("Enter an integer: ");
                int input = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n");

                Console.WriteLine("Number \t Squared \t Cubed");
                Console.WriteLine("======\t ======= \t =====");

                for (i = 1; i <= input; i++)
                {
                    Console.WriteLine(i + "\t " + (i * i) + "\t \t " + (i * i * i));
                }

                Console.WriteLine("\n");

                Console.Write("Do you want to continue?(y/n)");
                string t = Console.ReadLine();
                if (t.ToLower() == "n")
                    run = false;

                Console.WriteLine("\n");
                Console.Clear();

                Console.WriteLine("Learn you squares and cubes!");
                Console.WriteLine("\n ");


            } while (run);

            Console.WriteLine("\n");
            Console.WriteLine("Bye!");
            Console.ReadKey();
        }
    }
}
