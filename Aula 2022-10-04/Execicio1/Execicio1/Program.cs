using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.Write("番号を入力してください :");
            a = double.Parse(Console.ReadLine());
            Console.Write("番号を入力してください :");
            b = double.Parse(Console.ReadLine());
            double aa = A(a);
            double bb = A(b);
            Console.WriteLine("入力値 {0} 後　{1}", a, aa);
            Console.WriteLine("入力値 {0} 後　{1}", b, bb);
        }
        public static double A(double x)
        {
            double z = x * x;
            return z;
        }
    }
}
