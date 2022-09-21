using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execicios_c_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=30; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}
