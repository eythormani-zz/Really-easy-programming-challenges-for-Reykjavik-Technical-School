using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dæmi_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = null;
            for (int i = a.Length - 1; i != -1; i--)
            {
                b += a[i];
            }
            if (a == b)
            {
                Console.WriteLine("Strengurinn er eins speglaður!");
            }
            else
            {
                Console.WriteLine("Strengurinn speglast ekki");
            }
            Console.ReadLine();
        }
    }
}
