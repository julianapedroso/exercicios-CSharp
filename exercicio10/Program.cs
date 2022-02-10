using System;

namespace exercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 10 - Entrar com um número de 5 dígitos e imprimir o número da casa das dezenas. Por exemplo:
                Entrada: 78954
                Saída: 5 */

            Console.WriteLine("Digite um número de 5 dígitos: ");
            int numeroCincoDigitos = int.Parse(Console.ReadLine());

            int casaCentena = numeroCincoDigitos / 100;
            int casaDezena = (numeroCincoDigitos % 100) / 10;
            int casaUnidade = ((numeroCincoDigitos % 100) % 10);
            
            Console.WriteLine($"O número digitado foi: {numeroCincoDigitos} e o número da casa das unidades é: {casaDezena}");

            Console.ReadLine();
        }
    }
}
