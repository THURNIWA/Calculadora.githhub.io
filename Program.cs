﻿using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static void Soma()
        {
            Console.Clear();
            
            Console.WriteLine("Informe o primeiro numero: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo numero: ");
            float num2 = float.Parse(Console.ReadLine());

            float resultado = num1 + num2;

            Console.WriteLine("O resultado da soma é: " + resultado);

            Console.ReadKey();
        }

        static void subtracao()
        {
            Console.Clear();

            Console.WriteLine("Informe o primeiro valor: ");
            float num1 = float.Parse((Console.ReadLine()));

            Console.WriteLine("Informe o segundo valor: ");
            float num2 = float.Parse((Console.ReadLine()));

            float resultado = num1 - num2;

            Console.WriteLine("O resultado da subtração é: " + resultado);

            Console.ReadKey();
        }
    }
}