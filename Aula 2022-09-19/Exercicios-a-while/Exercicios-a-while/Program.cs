using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_a_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercícios :Apresentar todos os valores numéricos inteiros impares situados nafaixa de 0 a 20.
            int i = 0;
            while (i <= 20)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}
