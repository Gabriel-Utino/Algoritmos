using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint[] arrayQ = new uint[10];
            uint min;
            int element;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("digite um numero :");
                arrayQ[i] = uint.Parse(Console.ReadLine());
            }
            min = arrayQ.Min();
            element = Array.IndexOf(arrayQ, min);
            Console.WriteLine("menor valor :{0}", min);
            Console.WriteLine("O element :{0}", element);

        }
    }
}
