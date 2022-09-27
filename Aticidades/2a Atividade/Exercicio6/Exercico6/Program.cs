using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercico6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, soma;
            int[] vetor = new int[8];
            for(int i=0; i<8; i++)
            {
                Console.Write("degite um numero:");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            soma = vetor[x-1] + vetor[y-1];
            Console.WriteLine("soma :" + soma);
        }
    }
}
/*6. Faça um programa que leia um vetor de 8 posições e, em seguida, leia também dois
valores X e Y quaisquer correspondentes a duas posições no vetor. Ao final seu
programa deverá escrever a soma dos valores encontrados nas respectivas posições X e Y.*/