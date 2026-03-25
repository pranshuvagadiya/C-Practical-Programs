using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            string revname = "";

    

            for (int i =name.Length-1 ; i >= 0; i--)
            {
                revname = revname + name[i];
            }

            if (name == revname)
            {
                Console.WriteLine("Entered name is palindrom");
            }
            else
            {
                Console.WriteLine("Entered name is not palindrom");
            }

        }
    }
}
