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
            int c = Convert.ToInt32(Console.ReadLine());

            if (c <40 && c>-30)
            {
                Console.WriteLine("Közte van");
            }
            else
            {
                Console.WriteLine("Nincs közte");
            }

            Console.WriteLine("enter");
            Console.ReadLine();
        }
    }
}
