using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Uma empresa contrata um encanador a R$ 130,00 por dia. Crie um programa que 
            solicite  o  número  de  dias  trabalhados  pelo  encanador  e  imprima  a  quantia  
            líquida  que deverá ser paga, sabendo-se que são descontados 8% para imposto de 
            renda.*/

            Console.WriteLine("Informe os dias de trabalho do encanador: ");
            double diasTrabalho = double.Parse(Console.ReadLine());

            double calculoDiaTrabalho = 130 * diasTrabalho;
            double imposto = calculoDiaTrabalho * 8 / 100;
            double valorLiquido = calculoDiaTrabalho - imposto;

            Console.WriteLine($"O valor a ser pago pelos {diasTrabalho} dias, é de: R$ {valorLiquido}");

            Console.ReadLine();
        }
    }
}
