using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number:");
            int n = int.Parse(Console.ReadLine());

            int n1=0; 
            int n2=1;

            Console.WriteLine(n1 + " "); 
            Console.WriteLine(n2 + " ");
            int n3=0;

            do
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            } while (n3 < n);


        }
    }
}
