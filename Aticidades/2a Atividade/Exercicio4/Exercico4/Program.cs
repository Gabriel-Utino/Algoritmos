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
            int gender, i = 0, maleHeight, femaleHeight, man = 0, woman = 0,
                maleAge, femaleAge, femaleAllAge = 0, maleAllAge = 0,
                femaleAllHeight = 0, maleAllHeight = 0, population = 1000;
            double averageAge, averageFemaleHeight, averageMaleAge, percentAge18to35,
                countAge = 0;
            int[] arrayAge = new int[population];
            while (i< population)
            {
                Console.Write("sexo 0-feminino 1-masculino :");
                gender = int.Parse(Console.ReadLine());
                if(gender == 0)
                {
                    woman = woman + 1;
                    Console.Write("digite sua idade :");
                    femaleAge = int.Parse(Console.ReadLine());
                    femaleAllAge = femaleAllAge + femaleAge;
                    arrayAge[i] = femaleAge;
                    Console.Write("sua altura :");
                    femaleHeight = int.Parse(Console.ReadLine());
                    femaleAllHeight = femaleAllHeight + femaleHeight;
                } else
                {
                    man = man + 1;
                    Console.Write("digite sua idade :");
                    maleAge = int.Parse(Console.ReadLine());
                    maleAllAge = maleAllAge + maleAge;
                    arrayAge[i] = maleAge;
                    Console.Write("sua altura :");
                    maleHeight = int.Parse(Console.ReadLine());
                    maleAllHeight = maleAllHeight + maleHeight;
                }
                i++;
            }
            averageAge = (femaleAllAge + maleAllAge) / population;
            Console.WriteLine("média da idade do grupo :" + averageAge);
            averageFemaleHeight = femaleAllHeight / woman;
            Console.WriteLine("média da altura das mulheres :" + averageFemaleHeight);
            averageMaleAge = maleAllAge / woman;
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