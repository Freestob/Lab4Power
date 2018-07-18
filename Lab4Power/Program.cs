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
            Console.WriteLine("Enter in a number.");
            
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("{0,-10} {1,-10} {2,-10}", "Number", "Squared", "Cubed");



            for (int i = 1; i < x; i++)
            {
                int squared = i * i;
                int cubed = i * i * i;
                Console.WriteLine("{0, -10} {1, -10} {2, -10}" , i, squared, cubed);
            }
            Console.ReadKey();

        }
       
        
    }
}
