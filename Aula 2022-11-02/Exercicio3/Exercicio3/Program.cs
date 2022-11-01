using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            double a, b, retorna;
            Console.Write("volor do a :");
            a = double.Parse(Console.ReadLine());
            Console.Write("volor do b :");
            b = double.Parse(Console.ReadLine());
            Console.Write("escreva char :");
            ch = char.Parse(Console.ReadLine());
            retorna = Method(a, b, ch);
            Console.WriteLine("retorna :" + retorna);
        }
        public static double Method(double x, double y, char z)
        {
            if (z == '-')
            {
                return x - y;
            }
            else if (z == '/')
            {
                return x / y;
            }
            else if (z == '*')
            {
                return x * y;
            }
            else if (z == '+')
            {
                return x + y;
            }
            else
            {
                return 0;
            }
        }

    }
}
