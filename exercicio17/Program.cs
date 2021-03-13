using System;

namespace exercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 17 - Entrar com um número de 3 dígitos e imprimir o número da casa das unidades. Por exemplo:
                Entrada: 359
                Saída: 9 */

            Console.WriteLine("Digite um número de 3 dígitos: ");
            int numeroTresDigitos = int.Parse(Console.ReadLine());

            int casaCentena = numeroTresDigitos / 100;
            int casaDezena = (numeroTresDigitos % 100) / 10;
            int casaUnidade = ((numeroTresDigitos % 100) % 10);
            
            Console.WriteLine($"O número digitado foi: {numeroTresDigitos} e o número da casa das unidades é: {casaUnidade}");
            
            Console.ReadLine();
        }
    }
}
