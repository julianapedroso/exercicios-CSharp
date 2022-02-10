using System;

namespace exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 04 – Elabore um algoritmo que calcule a área e o perímetro de um retângulo.
                Área = b x h
                Perímetro = é a soma de todos os lados */

            Console.WriteLine("Digite um número para a base de um retângulo: ");
            double baseRetangulo = double.Parse(Console.ReadLine());

            Console.WriteLine("Agora digite um número para a altura desse retângulo: ");
            double alturaRetangulo = double.Parse(Console.ReadLine());

            double areaRetangulo = baseRetangulo * alturaRetangulo;
            double perimetroRetangulo = (baseRetangulo * 2) + (alturaRetangulo * 2);

            Console.WriteLine($"A área do retângulo é: {areaRetangulo} e o perímetro do retângulo é: {perimetroRetangulo}");

            Console.ReadLine();
        }
    }
}
