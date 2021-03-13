using System;

namespace exercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 19 - Entrar com os lados A, B e C de um paralelepípedo. Calcular e imprimir o volume.
                Volume = A * B * C */
            
            Console.WriteLine("Digite um número para o lado A do paralelepípedo: ");
            double valorDigitadoLadoA = double.Parse(Console.ReadLine());

            Console.WriteLine("Agora, digite um número para o lado B desse paralelepípedo: ");
            double valorDigitadoLadoB = double.Parse(Console.ReadLine());

            Console.WriteLine("Por fim, digite um número para o lado C desse paralelepípedo: ");
            double valorDigitadoLadoC = double.Parse(Console.ReadLine());

            double volumeParalelepipedo = valorDigitadoLadoA * valorDigitadoLadoB * valorDigitadoLadoC;

            Console.WriteLine($"O valor digitado para o lado A foi: {valorDigitadoLadoA}, para o lado B foi: {valorDigitadoLadoB} e para o C foi: {valorDigitadoLadoC}. O volume do paralelepípedo é de: {volumeParalelepipedo}");

            Console.ReadLine();
        }
    }
}
