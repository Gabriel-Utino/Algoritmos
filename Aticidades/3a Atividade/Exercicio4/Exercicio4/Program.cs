using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x,y,z,res;
            Console.Write("digite o numero :");
            x = double.Parse(Console.ReadLine());
            Console.Write("digite o numero :");
            y = double.Parse(Console.ReadLine());
            Console.Write("digite o numero :");
            z = double.Parse(Console.ReadLine());
            res = A(x, y, z);
            Console.WriteLine("menor dentre eles :{0}",res);
        }
        public static double A(double a, double b, double c)
        {
            if(a < b && a < c)
            {
                return a;
            }else if (b < a && b < c)
            {
                return b;
            }else
            {
                return c;
            }
        }
    }
}
