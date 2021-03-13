using System;

namespace exercicio23
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 23 - Elabore um algoritmo que possa calcular o volume de um cilindro (figura meramente ilustrativa).
                Volume = área da base x altura */

            Console.WriteLine("Digite um número para o raio do cilindro: ");
            double valorDigitadoRaioCilindro = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Agora, digite um número para a altura desse cilindro: ");
            double valorDigitadoAlturaCilindro = double.Parse(Console.ReadLine());

            double raioCilindro = valorDigitadoRaioCilindro;
            double alturaCilindro = valorDigitadoAlturaCilindro;
            double volumeCilindro = (Math.PI * (Math.Pow(raioCilindro, 2)) * alturaCilindro);

            Console.WriteLine($"O valor digitado para o raio do cilindro foi: {valorDigitadoRaioCilindro}, para a altura foi: {valorDigitadoAlturaCilindro} e seu volume é: {volumeCilindro}");

            Console.ReadLine();
        }
    }
}
