using System;

namespace exercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 16 - Elabore um algoritmo que entre com valor do raio e calcule a área e o perímetro do círculo correspondente.
                A fórmula para se calcular a área da circunferência é : A = π ∗ raio²
                A fórmula para se calcular o perímetro da circunferência é : A = 2 ∗ π ∗ r */

            Console.WriteLine("Digite um valor para o raio: ");
            double valorDigitadoRaio = double.Parse(Console.ReadLine());

            double valorAreaCircunferenicia = Math.PI * Math.Pow(valorDigitadoRaio, 2);
            double valorPerimetroCincunferencia = 2 * Math.PI * valorDigitadoRaio;
            
            Console.WriteLine($"O valor digitado para o raio é: {valorDigitadoRaio}, sua área é: {valorAreaCircunferenicia} e seu perímetro é: {valorPerimetroCincunferencia}");

            Console.ReadLine();
        }
    }
}
