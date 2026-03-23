using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayProg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];

            Console.WriteLine("Enter array elements: ");
            for (int i = 0; i <10; i++) {
                
                myArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(myArray[i]);
            }
                
            Console.WriteLine("In Reverse");

            for (int i = myArray.Length-1 ; i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);
            }

        }
    }
}
