using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1;
            int i2 = 0;
            int i3;
            Console.WriteLine("Enter a value for i3: ");
                string newi3 = Console.ReadLine();
                i3 = Convert.ToInt32(newi3);

            for (int i4 = 0; i4 < i3; i4++)
            { 

                Console.WriteLine("Enter the value for i1: ");
                string newi1 = Console.ReadLine();
                i1 = Convert.ToInt32(newi1);

                i2 = i2 + i1;

                
            }
            Console.WriteLine("Sum = {0}", i2);
            Console.ReadKey();
        }
    }
}
