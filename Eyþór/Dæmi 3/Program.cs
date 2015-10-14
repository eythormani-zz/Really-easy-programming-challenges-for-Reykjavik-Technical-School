using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dæmi_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = null;
            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 1)
                {
                    b += char.ToUpper(a[i]);
                }
                else
                {
                    b += a[i];
                }
            }
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
