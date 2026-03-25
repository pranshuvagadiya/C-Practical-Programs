using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] myArray = new int[5];
            Console.WriteLine("Enter 5 numbers: ");

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }

            int x = myArray[0];
            for (int i = 0; i < myArray.Length ; i++)
            {

                if (myArray[i] > x)
                {
                    x = myArray[i];
                }
            }
            Console.WriteLine("Max number is : " + x);
        }
    }
}
