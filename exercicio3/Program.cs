using System;

namespace exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 03 – Elabore um algoritmo que calcule a área e o perímetro de um quadrado.
                Área = lado²
                Perímetro = é a soma de todos os lados */

            Console.WriteLine("Digite um número para cálculo de área e perímetro de um quadrado: ");
            double ladoQuadrado = double.Parse(Console.ReadLine());

            double areaQuadrado = Math.Pow(ladoQuadrado, 2);
            double perimetroQuadrado = ladoQuadrado + ladoQuadrado + ladoQuadrado + ladoQuadrado;

            Console.WriteLine($"A área do quadrado é: {areaQuadrado} e o perímetro do quadrado é: {perimetroQuadrado}");

            Console.ReadLine();
        }
    }
}
