using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.Write("数字を入力せよ　:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("結果 :{0}",A(a));
        }
        public static double A(double a)
        {
            double z = Math.Sqrt(a);
            return z;
        }
    }
}
