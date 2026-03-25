using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number:");
            int n = int.Parse(Console.ReadLine());

            int m;
            int flag = 0;

            for (int i = 2; i <= n-1; i++)
            {
                m = n % i;
                if (m == 0)
                {
                    Console.WriteLine("It is not Prime number");
                    flag = 1;
                    break;
                }

            }

            if (flag == 0)
            {
                Console.WriteLine("It is Prime number");
            }

        }
    }
}
