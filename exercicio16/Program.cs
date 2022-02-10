using System;

namespace exercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 16 – Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Kelvin.
            A fórmula de conversão é: K = C + 273.15, sendo C a temperatura em Celsius e K a
            temperatura em Kelvin. */

            Console.WriteLine("Informe um valor para a temperatura em Celsius: ");
            double temperatura = double.Parse(Console.ReadLine());

            double temperaturaCelsius = 273.15;
            double temperaturaKelvin = temperatura + temperaturaCelsius;

            Console.WriteLine($"A conversão de {temperatura} em Celsius para Kelvin é: {temperaturaKelvin}K");

            Console.ReadLine();
        }
    }
}
