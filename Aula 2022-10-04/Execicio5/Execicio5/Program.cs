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
            for (int i= 0; i < 10; i++)
            {
                Console.Write("digite :");
                array[i] = int.Parse(Console.ReadLine());
            }
            int[] array2 = A(array);
            for(int i= 0; i < 10; i++)
            {
                Console.WriteLine("結果 :{0}", array2[i]);
            }
        }
        public static int[] A(int[] array)
        {
            int i = 0, r = 9;
            int[] zen = new int[10];
            while(i > 10)
            {
                zen[r] = array[i];
                i++;
                r--;
            }
            return zen;
        }
    }
}
