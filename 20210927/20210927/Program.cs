using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210927
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Írj be egy számot:");
            int szam = Convert.ToInt32(Console.ReadLine());
            switch (szam)
            {
                case 1:
                    Console.WriteLine("tél");
                    break;
                case 2:
                    Console.WriteLine("tél");
                    break;
                case 3:
                    Console.WriteLine("tavasz");
                    break;
                case 4:
                    Console.WriteLine("tavasz");
                    break;
                case 5:
                    Console.WriteLine("tavasz");
                    break;
                case 6:
                    Console.WriteLine("nyár");
                    break;
                case 7:
                    Console.WriteLine("nyár");
                    break;
                case 8:
                    Console.WriteLine("nyár");
                    break;
                case 9:
                    Console.WriteLine("ősz");
                    break;
                case 10:
                    Console.WriteLine("ősz");
                    break;
                case 11:
                    Console.WriteLine("ősz");
                    break;
                case 12:
                    Console.WriteLine("tél");
                    break;
                default:
                    Console.WriteLine("Nincs ilyen hónap");
                    break;
            }


            Console.WriteLine("enter");
            Console.ReadLine();
        }
    }
}
