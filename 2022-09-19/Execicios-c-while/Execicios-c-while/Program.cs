using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execicios_c_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Apresentar todos os números divisíveis por 4 que sejam menores que 30.Iniciar a contagem com o valor 1(um).
            int i=1;
            while (i <= 30)
            {
                if(i%4 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}
