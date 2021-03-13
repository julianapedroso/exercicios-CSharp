using System;

namespace exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 14 – Entrar com dois números inteiros e imprimir a seguinte saída:
                Dividendo:
                Divisor:
                Quociente:
                Resto: */

            Console.WriteLine("Digite um número para o dividendo: ");
            int valorDigitadoDividendo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número para o divisor: ");
            int valorDigitadoDivisor = int.Parse(Console.ReadLine());

            int valorDividendo = valorDigitadoDividendo;
            int valorDivisor = valorDigitadoDivisor;
            int valorQuociente = valorDigitadoDividendo / valorDigitadoDivisor;
            int valorResto = valorDigitadoDividendo % valorDigitadoDivisor;
            
            Console.WriteLine($"O número dividendo é: {valorDividendo}, o número divisor é: {valorDivisor}, o quociente é: {valorQuociente} e resto é: {valorResto}");
            
            Console.ReadLine();
        }
    }
}
