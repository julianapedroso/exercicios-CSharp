using System;

namespace exercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 15 – Entrar com quatro números e imprimir a média ponderada, sabendo-se que os 
            pesos são respectivamente 1, 2, 3 e 4. */

            Console.WriteLine("Digite um valor para a primeira nota: ");
            double valorDigitadoPrimeiraNota = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para a segunda nota: ");
            double valorDigitadoSegundaNota = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para a terceira nota: ");
            double valorDigitadoTerceiraNota = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para a quarta nota: ");
            double valorDigitadoQuartaNota = double.Parse(Console.ReadLine());

            double valorNota1 = valorDigitadoPrimeiraNota * 1;
            double valorNota2 = valorDigitadoSegundaNota * 2;
            double valorNota3 = valorDigitadoTerceiraNota * 3;
            double valorNota4 = valorDigitadoQuartaNota * 4;
            double mediaPonderada = (valorNota1 + valorNota2 + valorNota3 + valorNota4) / (10);
        
            Console.WriteLine($"O valor da primeira nota é: {valorDigitadoPrimeiraNota}, o da segunda é: {valorDigitadoSegundaNota}, o da terceira é: {valorDigitadoTerceiraNota} e o da quarta é: {valorDigitadoQuartaNota}. Logo, a média ponderada é: {mediaPonderada}");

            Console.ReadLine();
        }
    }
}
