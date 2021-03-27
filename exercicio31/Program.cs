using System;

namespace exercicio31
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 31–Construa  um  algoritmo  para calcular  o  Volume  da  figura  ao  lado  
            (a  figura  é ilustrativa): Fórmulas: 
            Área do polígono = Lado1 x Lado2
            Área da circunferência = pi x raio²
            Volume = (Área do polígono – Área da circunferência) x altura da figura. */

            Console.WriteLine("Digite um número o primeiro lado: ");
            double primeiroLado = double.Parse(Console.ReadLine());

            Console.WriteLine("Agora, digite um número o segundo lado: ");
            double segundoLado = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite uma altura para o poligno: ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Por fim, informe um número para o raio: ");
            double raio = double.Parse(Console.ReadLine());

            double areaPoligono = primeiroLado * segundoLado;
            double alturaPoligono = altura;
            double raioCircunferencia = raio;
            double areaCirfunferencia = Math.PI * Math.Pow(raioCircunferencia, 2);
            double volumePoligono = (areaPoligono - areaCirfunferencia) * (alturaPoligono);

            Console.WriteLine($"A área do poligono é: {areaPoligono}, sua altura é: {alturaPoligono}, a área de sua cirfunferência é: {areaCirfunferencia} e seu volume é: {volumePoligono}");

            Console.ReadLine();
        }
    }
}
