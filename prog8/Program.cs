using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int a = int.Parse(Console.ReadLine());

            int fact = 1;

            for (int i = a; i >= 1; i--)
            {
               fact = fact * i;
            }

            Console.WriteLine("Factorial is:" + fact);
        }
    }
}
