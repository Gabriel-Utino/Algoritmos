using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] vetor = new int[10];
            while (i < 10)
            {
                Console.WriteLine("digite");
                vetor[i] = int.Parse(Console.ReadLine());
                i++;
            }
            for(int o=0; 0<10; o++)
            {
                if (vetor[o] % 2 == 1)
                {
                    Console.WriteLine(vetor[o]);
                }
            }
        }
    }
}
