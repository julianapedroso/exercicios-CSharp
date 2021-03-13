using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 03 – Crie um algoritmo que leia dois nomes e imprima os nomes na sequência 
            em que foram escritos e posteriormente os imprima na ordem inversa. */

            string primeiroNome = "Caio";
            string segundoNome = "Amanda";

            Console.WriteLine($"{primeiroNome}, {segundoNome}");
            Console.WriteLine($"{segundoNome}, {primeiroNome}");

            Console.ReadLine();
        }
    }
}
