using System;

namespace exercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 11 - Elabore um algoritmo que calcule a área de um trapézio qualquer (figura meramente ilustrativa).
                Área = [(𝐵+𝑏) ×ℎ]/(2) */

            Console.WriteLine("Digite um número para a base maior do trapézio: ");
            double valorDigitadoBaseMaior = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Agora, digite um número para a base menor desse trapézio: ");
            double valorDigitadoBaseMenor = double.Parse(Console.ReadLine());

            Console.WriteLine("Por fim, digite um número para a altura desse trapézio: ");
            double valorDigitadoAltura = double.Parse(Console.ReadLine());

            double baseMAior = valorDigitadoBaseMaior;
            double baseMenor = valorDigitadoBaseMenor;
            double altura = valorDigitadoAltura;
            double areaTrapezio = (baseMAior + baseMenor) * valorDigitadoAltura / (2);

            Console.WriteLine($"O valor digitado para o lado maior foi: {valorDigitadoBaseMaior}, para o lado menor foi: {valorDigitadoBaseMenor} e para a altura foi: {altura}. A área do trapézio é de: {areaTrapezio}");

            Console.ReadLine();
        }
    }
}
