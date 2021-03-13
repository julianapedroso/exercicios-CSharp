using System;

namespace exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /* 12 – Crie um Algoritmo que receba um número e imprima seu valor elevado a 2, elevado a 3, elevado a 4 e elevado a 5.
               SAÍDA:
               O número digitado foi ... E seu valor elevado a 2 é ..., elevado a 3 é ..., ... */

            Console.WriteLine("Digite um número: ");
            double numeroPotencia = double.Parse(Console.ReadLine());

            double numeroQuadrado = Math.Pow(numeroPotencia, 2);
            double numeroCubo = Math.Pow(numeroPotencia, 3);
            double numeroQuarta = Math.Pow(numeroPotencia, 4);
            double numeroQuinta = Math.Pow(numeroPotencia, 5);

            Console.WriteLine($"O número digitado foi: {numeroPotencia}, seu valor elevado a 2 é: {numeroQuadrado}, elevado a 3 é: {numeroCubo}, elevado a 4 é: {numeroQuarta} e elevado a 5 é: {numeroQuinta}");

            Console.ReadLine();
        }
    }
}
