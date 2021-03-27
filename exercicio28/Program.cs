using System;

namespace exercicio28
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 28 – Ler uma temperatura em graus Kelvin e apresentá-la convertida em graus Celsius.
            A fórmula de conversão é: C = K – 273.15, sendo C a temperatura em Celsius e K a
            temperatura em Kelvin.*/

            Console.WriteLine("Informe um valor para a temperatura em Kelvin: ");
            double temperatura = double.Parse(Console.ReadLine());

            double temperaturaKelvin = 273.15;
            double temperaturaCelsius = temperatura - temperaturaKelvin;

            Console.WriteLine($"A conversão de {temperatura} em Kelvin para Celsius é: {temperaturaCelsius}°");

            Console.ReadLine();
        }
    }
}
