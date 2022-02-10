using System;

namespace exercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 12 - Crie um algoritmo que possa calcular a área de uma coroa de forma circular (figura meramente ilustrativa).
                Área circunferência = π x r²
                Área coroa circular = (Área da circunferência maior) – (Área da circunferência menor) */

            Console.WriteLine("Digite um número para o raio maior da coroa circular: ");
            double valorDigitadoCoronaMaior = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Agora, digite um número para o raio menor dessa coroa circular: ");
            double valorDigitadoCoronaMenor = double.Parse(Console.ReadLine());

            double raioMaior = valorDigitadoCoronaMaior;
            double areaCoroaMaior = Math.PI * Math.Pow(raioMaior, 2);
            double raioMenor = valorDigitadoCoronaMenor;
            double areaCoroaMenor = Math.PI * Math.Pow(raioMenor, 2);
            double areaCoroaCircular = areaCoroaMaior - areaCoroaMenor;

            Console.WriteLine($"O valor digitado para o raio da coroa maior foi: {valorDigitadoCoronaMaior}, para o da coroa menor foi: {valorDigitadoCoronaMenor}. Sua área é: {areaCoroaCircular}");

            Console.ReadLine();
        }
    }
}
