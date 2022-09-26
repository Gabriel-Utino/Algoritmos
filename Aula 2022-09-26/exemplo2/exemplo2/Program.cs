using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[5];
            for (int i=0; i<5; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Imprime invertido :");
            for (int i=4; i>=0; i--)
            {
                Console.WriteLine(v[i]);
            }
        }
    }
}
