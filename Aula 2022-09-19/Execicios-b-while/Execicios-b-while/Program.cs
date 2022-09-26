using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execicios_b_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Apresentar o total da soma dos cem primeiros números inteiros, 
             * representados pela sequencia 1 + 2 + 3 + 4 + 5 + 6 + 7 + ...+97 + 98 + 99 + 100.*/
            int i = 1, total = 0;
            while (i <= 100)
            {
                total = total + i;
                i++;
            }
            Console.WriteLine(total);
        }
    }
}
