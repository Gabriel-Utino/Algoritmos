using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
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
        public static int Method(int a)
        {
            if (a % 2 == 1)
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