using System;

namespace exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 11- Crie um Algoritmo que receba um número e imprima sua raiz quadrada.
                SAÍDA:
                A raiz quadrada do número .... é ... */

            Console.WriteLine("Digite um número: ");
            double numeroRaiz = double.Parse(Console.ReadLine());

            double raizQuadrada = Math.Sqrt(numeroRaiz);

            Console.WriteLine($"A raiz quadrada do número: {numeroRaiz} é: {raizQuadrada}");

            Console.ReadLine();
        }
    }
}
