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
                    Console.WriteLine("január");
                    break;
                case 2:
                    Console.WriteLine("február");
                    break;
                case 3:
                    Console.WriteLine("március");
                    break;
                case 4:
                    Console.WriteLine("április");
                    break;
                case 5:
                    Console.WriteLine("május");
                    break;
                case 6:
                    Console.WriteLine("június");
                    break;
                case 7:
                    Console.WriteLine("július");
                    break;
                case 8:
                    Console.WriteLine("augusztus");
                    break;
                case 9:
                    Console.WriteLine("szeptember");
                    break;
                case 10:
                    Console.WriteLine("október");
                    break;
                case 11:
                    Console.WriteLine("november");
                    break;
                case 12:
                    Console.WriteLine("december");
                    break;
                default:
                    Console.WriteLine("Nem hónap");
                    break;
            }


            Console.WriteLine("enter");
            Console.ReadLine();
        }
    }
}
