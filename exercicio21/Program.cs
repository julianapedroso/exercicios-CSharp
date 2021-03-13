using System;

namespace exercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 21 - Construa um algoritmo que possa calcular o volume de um prisma de base triangular (figura meramente ilustrativa).
                Volume = área da base x altura. */

            Console.WriteLine("Digite um número para a base do prisma: ");
            double valorDigitadoPrismaBase = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Agora, digite um número para a altura desse prisma: ");
            double valorDigitadoPrismaAltura = double.Parse(Console.ReadLine());

            double basePrisma = valorDigitadoPrismaBase;
            double alturaPrisma = valorDigitadoPrismaAltura;
            double volumePrisma = basePrisma * alturaPrisma;

            Console.WriteLine($"O valor digitado para a base do prisma foi: {valorDigitadoPrismaBase}, para a altura foi: {valorDigitadoPrismaAltura} e seu volume é: {volumePrisma}");

            Console.ReadLine();
        }
    }
}
