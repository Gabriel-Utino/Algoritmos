using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercico4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gender, i = 0, age, allAge = 0, height, allHeight = 0 ,
                woman = 0, male = 0, population = 1000;
            double averageAge, averageHeight;
            while (i< population)
            {
                Console.WriteLine("sexo 1-feminino 2-masculino :");
                gender = int.Parse(Console.ReadLine());
                if(gender == 1)
                {
                    woman = woman + 1;
                } else
                {
                    male = male + 1;
                }
                Console.WriteLine("digite sua idade :");
                age = int.Parse(Console.ReadLine());
                allAge = allAge + age;
                Console.WriteLine("sua altura :");
                height = int.Parse(Console.ReadLine());
                allHeight = allHeight + height;
            }
            averageAge = allAge / population;
            averageHeight = allAge / population;
        }
    }
}
/*4. Foi feita uma pesquisa entre os 1000 habitantes de uma região para coletar os
seguintes dados: sexo (0-feminino, 1-masculino), idade e altura. Faça um programa
que leia as informações coletadas e mostre as seguintes informações na tela:
a) média da idade do grupo;
b) média da altura das mulheres;
c) média da idade dos homens;
d) percentual de pessoas com idade entre 18 e 35 anos (inclusive).*/