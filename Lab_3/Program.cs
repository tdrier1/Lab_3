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

            Console.WriteLine("Learn you squares and cubes!");

            Console.WriteLine("Enter an integer: ");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number \t Squared \t Cubed");
            Console.WriteLine("======\t ====== \t =====");

            for(i = 1; i <= input; i++)
            {
                Console.WriteLine(i + "\t" + (i*i) + "\t" + (i*i*i));
                

            }


        }
    }
}
