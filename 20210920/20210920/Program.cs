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

            if (b % 2< 0)
            {
                Console.WriteLine("Kint fagy");
            }
            else
            {
                Console.WriteLine("Kint nem fagy");
            }

            Console.WriteLine("enter");
            Console.ReadLine();
        }
    }
}
