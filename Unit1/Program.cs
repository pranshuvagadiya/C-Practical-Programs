using System;

namespace Unit1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of a : ");
            double a = int.Parse(Console.ReadLine());
            Console.Write("Enter the value of b : ");
            double b = Convert.ToInt32(Console.ReadLine());

            double c = a + b;
            double d = a - b;
            double e = a * b;
            double f = a % b;
            double g = a / b;

            Console.WriteLine("Addition: " + c);
            Console.WriteLine("Subtraction: " + d);
            Console.WriteLine("Multiplication: " + e);
            Console.WriteLine("Division: " + g);
            Console.WriteLine("Modulus: " + f);
            
        }
    }
}
