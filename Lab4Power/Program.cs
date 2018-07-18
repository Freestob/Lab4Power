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
           
            
            for (int i = 0; i < x; i++)
            {
                int square = i * i;
                int cubed = i * i * i;
                Console.WriteLine("{0} {1} {2}" , i, square, cubed);
            }
            Console.ReadKey();

        }
       
        
    }
}
