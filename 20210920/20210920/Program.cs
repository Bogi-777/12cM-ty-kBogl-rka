using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210920
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = Convert.ToInt32(Console.ReadLine());

            if (b % 2 == 0)
            {
                Console.WriteLine("A szám pozítiv");
            }
            else
            {
                Console.WriteLine("A szám negatív");
            }

            Console.WriteLine("enter");
            Console.ReadLine();
        }
    }
}
