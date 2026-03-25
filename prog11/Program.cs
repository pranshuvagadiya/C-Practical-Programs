using System;

namespace PrimeRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter starting number: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter ending number: ");
            int end = int.Parse(Console.ReadLine());


            for (int n = start; n <= end; n++)
            {
                int flag = 0;

                for (int i = 2; i <= n - 1 ; i++)
                {
                    if (n % i == 0)
                    {
                        flag = 1;
                        break;
                    }
                }

                if (flag == 0)
                {
                    Console.Write(n + " ");
                }  
                
            }
        }
    }
}

