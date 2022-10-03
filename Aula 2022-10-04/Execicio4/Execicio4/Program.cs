using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int res;
            int[] vetor = new int[10];
            for(int i = 0; i < vetor.Length; i++)
            {
                Console.Write("digite o numero :");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            res = A(vetor);
            Console.WriteLine("quantidade de números impares :{0}", res);
        }
        public static int A(int[] array)
        {
            int count = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i]%2 == 1)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
