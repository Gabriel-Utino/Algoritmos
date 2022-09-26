using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            for (int i = 10; i <= 0; i--)
            {
                vetor[i] = i;
            }
            for (int i=1; i<=10; i++)
            {
                Console.WriteLine(vetor[i]);
            }
        }
    }
}
