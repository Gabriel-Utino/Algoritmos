using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execicios_b_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            for (int i=0; i<=100; i++)
            {
                total = total + i;
            }
            Console.WriteLine(total);
        }
    }
}
