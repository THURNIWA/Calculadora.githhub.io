using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro numero: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo numero: ");
            float num2 = float.Parse(Console.ReadLine());

            float resultado = num1 + num2;
        }
    }
}