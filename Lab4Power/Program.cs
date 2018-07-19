using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Power
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter in a number.");
                

                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("{0,-10} {1,-10} {2,-10}", "Number", "Squared", "Cubed");
                Console.WriteLine("{0,-10} {1,-10} {2,-10}", "=======", "=======", "=======");



                for (int i = 1; i <= x; i++)
                {
                    int squared = i * i;
                    int cubed = i * i * i;
                    Console.WriteLine("{0, -10} {1, -10} {2, -10}", i, squared, cubed);
                }
                Console.WriteLine("Do you want to run again (Y/N)? ");
                

                if (Console.ReadLine().ToLower() != "y")
                {
                    Console.WriteLine("Goodbye");
                    Console.ReadLine();
                    break;

                }
            }
        }
    }
}
