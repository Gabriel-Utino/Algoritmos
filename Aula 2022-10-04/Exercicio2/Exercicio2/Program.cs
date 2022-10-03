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
            double x, y;
            Console.Write("底辺 :");
            x = double.Parse(Console.ReadLine());
            Console.Write("高さ :");
            y = double.Parse(Console.ReadLine());
            double res = A(x, y);
            Console.WriteLine("結果　:{0}",res);
        }
        public static double A(double a,double b)
        {
            double z = a * b;
            return z;
        }
    }
}
