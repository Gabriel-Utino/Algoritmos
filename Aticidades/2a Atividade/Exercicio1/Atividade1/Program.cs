using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dados: 10 números digitados pelo usuário. Construa algoritmo para mostrar os
            valores negativos e que calcule e mostre a média dos valores menores que zero.*/
            int i = 0;
            double average = 0, all = 0, count = 0;
            double[] array = new double[10];
            var negative = new List<double>();
            while (i < 10)
            {
                Console.Write("digite numero :");
                array[i] = double.Parse(Console.ReadLine());
                if (array[i] < 0)
                {
                    negative.Add(array[i]);
                    all = all + array[i];
                    count++;
                }
                i++;
            }
            average = all / count;
            Console.WriteLine("valores negativos");
            foreach (var str in negative)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("média dos valores menores que zero :" + average);
        }
    }
}
