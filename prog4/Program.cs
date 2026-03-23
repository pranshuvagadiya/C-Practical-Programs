using System;


namespace prog4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Radius of Circle : ");
            double r =  double.Parse(Console.ReadLine());
            double pi = 3.14;
            
            double a = pi * Math.Pow(r,2);
            Console.WriteLine("Area of Circle is : " + a);   
        }
    }
}
