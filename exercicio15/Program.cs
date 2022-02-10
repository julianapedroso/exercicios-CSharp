using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 15 - Faça  um  programa  que  leia  o  valor  da  hora  de  trabalho e  o  número  
            de  horas trabalhadas no mês, e exiba na tela o valor a ser pago ao funcionário, 
            adicionando 10% sobre o valor calculado. */

            Console.WriteLine("Insira as horas trabalhadas no mês: ");
            double horas = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor a ser pago por hora: ");
            double valorPago = double.Parse(Console.ReadLine());
            double valorAdicional = horas * valorPago * 10 / 100;
            double valorMensal = (horas * valorPago) + (valorAdicional);

            Console.WriteLine($"Foram trabalhadas {horas} horas a um preço de R$ {valorPago}. O pagamento total foi de: R$ {valorMensal}");

            Console.ReadLine();
        }
    }
}
