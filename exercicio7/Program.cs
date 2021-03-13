using System;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 07 – Ler um número inteiro e imprimir seu antecessor e seu sucessor.
                SAÍDA:
                O número digitado foi ..., seu antecessor é ... e seu sucessor é ... */

            Console.WriteLine("Digite um número: ");
            int numeroDigitado = int.Parse(Console.ReadLine());

            int numeroAntecessor = numeroDigitado - 1;
            int numeroSucessor = numeroDigitado + 1;

            Console.WriteLine($"O número digitado foi: {numeroDigitado}, seu antecessor é: {numeroAntecessor} e seu número sucessor é: {numeroSucessor}");

            Console.ReadLine();
        }
    }
}
