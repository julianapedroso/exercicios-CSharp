using System;

namespace exercicio24
{
    class Program
    {
        static void Main(string[] args)
        {
             /* 24 - Elabore um algoritmo para calcular o volume e a área de uma esfera(figura meramente ilustrativa). 
                Área = 4 × 𝜋 × 𝑟²
                Volume = 4 / 3 × 𝜋 × 𝑟³ */

            Console.WriteLine("Digite um número para o raio da esfera: ");
            double valorDigitadoRaioEsfera = double.Parse(Console.ReadLine());

            double raioEsfera = valorDigitadoRaioEsfera;
            double areaEsfera = 4 * (Math.PI * (Math.Pow(raioEsfera, 2)));
            double volumeEsfera = 4 * (Math.PI * (Math.Pow(raioEsfera, 3))) / (3);

            Console.WriteLine($"O valor digitado para o raio da esfera foi: {valorDigitadoRaioEsfera}, sua área é: {areaEsfera} e seu volume é: {volumeEsfera}");

            Console.ReadLine();
        }
    }
}
