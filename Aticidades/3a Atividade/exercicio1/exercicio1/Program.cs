﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            var str = new List<int>();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("digite um numero :");
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                for(int e=0; e < 10; e++)
                {
                    if(i != e && array[i] == array[e])
                    {
                        count++;
                        str.Add(array[i]);
                    }
                }
            }
            if(count == 0)
            {
                Console.WriteLine("Nenhum");
            } else
            {
                Console.WriteLine("existem valores iguais :");
                for(int i = 0; i < count/2; i++)
                {
                    Console.WriteLine(str[i]);
                }
            }
        }
    }
}
