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
            int gender, i = 0, maleHeight, womanHeight, woman = 0, maleAge, womanAge,
                womanAllAge = 0, male = 0, maleAllAge = 0, womanAllHeight = 0, 
                maleAllHeight = 0, population = 1000;
            double averageAge, averageWomanHeight, averageMaleAge, percentAge18to35,
                countAge = 0;
            int[] arrayAge = new int[population];
            while (i< population)
            {
                Console.WriteLine("sexo 0-feminino 1-masculino :");
                gender = int.Parse(Console.ReadLine());
                if(gender == 0)
                {
                    woman = woman + 1;
                    Console.WriteLine("digite sua idade :");
                    womanAge = int.Parse(Console.ReadLine());
                    womanAllAge = womanAllAge + womanAge;
                    arrayAge[i] = womanAge;
                    Console.WriteLine("sua altura :");
                    womanHeight = int.Parse(Console.ReadLine());
                    womanAllHeight = womanAllHeight + womanHeight;
                } else
                {
                    male = male + 1;
                    Console.WriteLine("digite sua idade :");
                    maleAge = int.Parse(Console.ReadLine());
                    maleAllAge = maleAllAge + maleAge;
                    arrayAge[i] = maleAge;
                    Console.WriteLine("sua altura :");
                    maleHeight = int.Parse(Console.ReadLine());
                    maleAllHeight = maleAllHeight + maleHeight;
                }
                i++;
            }
            averageAge = (womanAllAge + maleAllAge) / population;
            Console.WriteLine("média da idade do grupo :" + averageAge);
            averageWomanHeight = womanAllHeight / woman;
            Console.WriteLine("média da altura das mulheres :" + averageWomanHeight);
            averageMaleAge = maleAllAge / male;
            Console.WriteLine("média da idade dos homens :" + averageMaleAge);
            foreach (int eachAge in arrayAge)
            {
                if(eachAge >= 18 && eachAge <= 35)
                {
                    countAge++;
                }
            }
            Console.WriteLine(countAge + " otameshi " + population);
            percentAge18to35 = (countAge / population) * 100;
            Console.WriteLine("percentual de pessoas com idade entre 18 e 35 anos :" + Math.Floor(percentAge18to35));
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