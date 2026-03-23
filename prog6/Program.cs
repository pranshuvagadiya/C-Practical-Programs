using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the number : ");
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else { 
            Console.WriteLine("The number is odd");
            }

        }
    }
}
