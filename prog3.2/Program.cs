using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Amount: ");    
            double p = float.Parse(Console.ReadLine());
            Console.Write("Enter Rate of Interest: ");
            double r = float.Parse(Console.ReadLine());
            Console.Write("Enter number of Years: ");
            double n = float.Parse(Console.ReadLine());

            double amount = p * Math.Pow((1 + r / 100), n);
            double compound_Interest = amount - p;

            Console.WriteLine("Compound Interest is : " + compound_Interest);

        }
    }
}
