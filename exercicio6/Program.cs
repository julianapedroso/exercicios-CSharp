using System;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 06 – Ler dois números e exibir as seguintes mensagens:
                O números digitados foram ... e .... .
                A soma dos números ... e ... é ... .
                A subtração dos números ... e ... é ... .
                A multiplicação dos números ... e ... é ... .
                A divisão dos números ... e ... é ... .
                A média dos números ... e ... é ... . */

            Console.WriteLine("Digite um número: ");
            int primeiroNumeroDigitado = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número: ");
            int segundoNumeroDigitado = int.Parse(Console.ReadLine());

            int somaNumerosDigitados = primeiroNumeroDigitado + segundoNumeroDigitado;
            int subtracaoNumerosDigitados = primeiroNumeroDigitado - segundoNumeroDigitado;
            int multiplicacaoNumerosDigitados = primeiroNumeroDigitado * segundoNumeroDigitado;
            int divisaoNumerosDigitados = primeiroNumeroDigitado / segundoNumeroDigitado;
            int mediaNumerosDigitados = somaNumerosDigitados / 2;

            Console.WriteLine($"Os números digitados foram: {primeiroNumeroDigitado}, {segundoNumeroDigitado}");
            Console.WriteLine($"A soma dos números: {primeiroNumeroDigitado} e {segundoNumeroDigitado} é: {somaNumerosDigitados}");
            Console.WriteLine($"A subtração dos números: {primeiroNumeroDigitado} e {segundoNumeroDigitado} é: {subtracaoNumerosDigitados}");
            Console.WriteLine($"A multiplicação dos números: {primeiroNumeroDigitado} e {segundoNumeroDigitado} é: {multiplicacaoNumerosDigitados}");
            Console.WriteLine($"A divisão dos números: {primeiroNumeroDigitado} e {segundoNumeroDigitado} é: {divisaoNumerosDigitados}");
            Console.WriteLine($"A média dos números: {primeiroNumeroDigitado} e {segundoNumeroDigitado} é: {mediaNumerosDigitados}");

            Console.ReadLine();
        
        }
    }
}
