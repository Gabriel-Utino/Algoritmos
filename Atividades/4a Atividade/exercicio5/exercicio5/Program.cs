﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Gabriel Casimiro Utino  
             * ADS  
             * turma 315-01AM */
            double[] arrayA = new double[10];
            double[] arrayM = new double[10];
            double x;
            for(int i=0; i<arrayA.Length; i++)
            {
                Console.Write("digite um numero :");
                arrayA[i] = double.Parse(Console.ReadLine());
            }
            Console.Write("digite o numero do x :");
            x = double.Parse(Console.ReadLine());
            for(int i=0; i<arrayM.Length; i++)
            {
                arrayM[i] = arrayA[i] * x;
                Console.WriteLine(arrayM[i]);
            }
        }
    }
}
