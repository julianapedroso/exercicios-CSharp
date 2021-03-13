using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 04 – Crie um algoritmo que receba duas variáveis do tipo inteiro.
            Atribuir um valor para cada variável e posteriormente exibir este valor.
            Para finalizar, exibir a primeira variável acrescida de uma unidade e exibir a 
            segunda variável decrescida de uma unidade.. */

            Console.WriteLine("Digite um número: ");
            int primeiroNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número: ");
            int segundoNumero = int.Parse(Console.ReadLine());

            int numeroAcrescido = primeiroNumero + 1;
            int numeroDecrescido = segundoNumero - 1;

            Console.WriteLine($"Os números digitados foram: {primeiroNumero} e {segundoNumero}. O primeiro valor +1 é: {numeroAcrescido} e o segundo valor -1 é: {numeroDecrescido}");

            Console.ReadLine();
        }
    }
}
