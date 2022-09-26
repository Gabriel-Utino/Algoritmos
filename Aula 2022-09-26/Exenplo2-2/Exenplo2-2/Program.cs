using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exenplo2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            int num;
            for (int i = 10; i > 0; i--)
            {
                num = i - 1;
                vetor[num] = i;
            }
            Console.WriteLine("tekitou ni kaku");
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine(vetor[i]);
            }
        }
    }
}
