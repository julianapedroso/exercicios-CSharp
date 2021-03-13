using System;

namespace exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 13 – Crie um Algoritmo que receba um número e imprima sua raiz quadrada e sua raiz cúbica.
                SAÍDA:
                O número digitado foi ...
                Sua raiz cúbica é ...
                Sua raiz quadrada é ... */

            Console.WriteLine("Digite um número: ");
            double valorDigitadoRaiz = double.Parse(Console.ReadLine());

            double valorRaizCubica = Math.Cbrt(valorDigitadoRaiz);
            double valorRaizQuadrada = Math.Sqrt(valorDigitadoRaiz);
            
            Console.WriteLine($"O número digitado foi: {valorDigitadoRaiz}, sua raiz cúbica é: {valorRaizCubica} e sua raiz quadrada é: {valorRaizQuadrada}");

            Console.ReadLine();
        }
    }
}
