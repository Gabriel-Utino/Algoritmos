using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace execicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius, f;
            Console.Write("Celsius :");
            celsius = double.Parse(Console.ReadLine());
            f = converTemp(celsius);
            Console.WriteLine("Fahrenheit :{0}", f);
        }
        public static double converTemp(double c)
        {
            double f;
            f = (9 * c + 160) / 5;
            return f;
        }
    }
}
