using System;

namespace exercicio30
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 18 – Ler uma velocidade em km/h (quilômetros por hora) e apresentá-la convertida em
            m/s (metros por segundo). A fórmula de conversão é: M = K/3.6, sendo K a velocidade
            em km/h e M em m/s. */

            Console.WriteLine("Insira um valor para a velocidade: ");
            double velocidade = double.Parse(Console.ReadLine());

            double conversao = velocidade / 3.6;
            double velocidadeConvertida = conversao;

            Console.WriteLine($"A velocidade {velocidade}km/h convertida para metros por segundo é de: {velocidadeConvertida}m/s");

            Console.ReadLine();
        }
    }
}
