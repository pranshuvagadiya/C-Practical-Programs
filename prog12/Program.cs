using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int num = int.Parse(Console.ReadLine());

            int m;
            int sum = 0;

            while (num > 0) {

                m = num % 10;
                num=num / 10;
                sum = sum + m;

            }
              Console.WriteLine(sum);

        }
    }
}
