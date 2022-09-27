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
            int X, Y;
            int[] vetor = new int[8];
            for(int i=0; i<8; i++)
            {
                vetor[i] = int.Parse(Console.ReadLine());
            }
            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());
        }
    }
}
/*6. Faça um programa que leia um vetor de 8 posições e, em seguida, leia também dois
valores X e Y quaisquer correspondentes a duas posições no vetor. Ao final seu
programa deverá escrever a soma dos valores encontrados nas respectivas posições X e Y.*/