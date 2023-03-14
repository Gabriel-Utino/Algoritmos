using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double base_maior, base_menor, altura, area;

            Console.Write("escreva voler do base maior : ");
            base_maior = double.Parse(Console.ReadLine());

            Console.Write("escreva voler do base menor : ");
            base_menor = double.Parse(Console.ReadLine());

            Console.Write("escreva voler do altura : ");
            altura = double.Parse(Console.ReadLine());

            area = ((altura * base_maior) + (altura * base_menor)) / 2;
            Console.WriteLine("area do Trapezios : " + area);

        }
    }
}
