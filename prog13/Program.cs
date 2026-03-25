using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int n1=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int n2=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter third number: ");
            int n3=int.Parse(Console.ReadLine());

            if (n1 < n2 && n1 < n3)
            {
                Console.WriteLine(n1 + " is minimum");
            }
            else if (n2 < n3 && n2 < n1)
            {
                Console.WriteLine(n2 + " is minimum");
            }
            else if(n3 < n1 && n3 < n2) 
            { 
                Console.WriteLine(n3 + " is minimum");
            }
            else
            {
                Console.WriteLine("Equal");
            }

        }
    }
}
