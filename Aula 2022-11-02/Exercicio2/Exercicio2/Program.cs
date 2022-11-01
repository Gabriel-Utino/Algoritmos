using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = Method(a);
            Console.WriteLine(b);
        }
        public static int Method(int x)
        {
            if (x < 0)
            {
                return -1;
            }
            else if (x == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

    }
}
