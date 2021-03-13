using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 05 – Cria um algoritmo que receba 5 números do tipo double e exiba a soma com 
            a seguinte frase:
                “Os números digitados foram ..., ..., ..., ... e sua soma é ... */

            Console.WriteLine("Digite o primeiro número: ");
            double primeiroNumero = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double segundoNumero = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número: ");
            double terceiroNumero = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o quarto número: ");
            double quartoNumero = double.Parse(Console.ReadLine());

            Console.WriteLine("E por fim, digite o quinto número: ");
            double quintoNumero = double.Parse(Console.ReadLine());

            double soma = primeiroNumero + segundoNumero + terceiroNumero + quartoNumero + quintoNumero;

            Console.WriteLine($"Os números digitados foram: {primeiroNumero}, {segundoNumero}, {terceiroNumero}, {quartoNumero}, {quintoNumero} e sua soma é: {soma}");

            Console.ReadLine();
        }
    }
}
