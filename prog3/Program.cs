using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Simple Interest----");

            Console.Write("Enter Amount: ");
            double p = float.Parse(Console.ReadLine());
            Console.Write("Enter Rate of Interest: ");
            double r = float.Parse(Console.ReadLine());
            Console.Write("Enter number of Years: ");
            double n = float.Parse(Console.ReadLine());

            double interest = (p * r * n) / 100;
            Console.WriteLine("Simple Interest is : " + interest);


        }
    }
}
