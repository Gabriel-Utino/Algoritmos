using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write("digite o numero :");
                array[i] = int.Parse(Console.ReadLine());
            }
            int res = A(array);
            Console.WriteLine(res);
        }
        public static int A(int[] vetor)
        {
            int res = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if(vetor[i]%2 == 1)
                {
                    res = res + vetor[i];
                }
            }
            return res;
        }
    }
}
