using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a 3-digit number: ");
            int num = int.Parse(Console.ReadLine());

            int original = num;
            int sum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                sum = sum + digit * digit * digit;  
                num = num / 10;   
            }

            if (sum == original)
            {
                Console.WriteLine("Armstrong Number");
            }
            else
            {
                Console.WriteLine("Not an Armstrong Number");
            }

    }
    }
}
