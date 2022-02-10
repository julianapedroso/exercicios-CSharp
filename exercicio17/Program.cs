using System;

namespace exercício29
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 17 - A  importância  de  R$  ******,**  (valor  do  prêmio) será  dividida  
            entre  três ganhadores de um concurso. Sendo que da quantia total:
            O primeiro ganhador receberá 46%; 
            O segundo receberá 32%; 
            O terceiro receberá o restante. 
            Calcule e imprima a quantia ganha por cada um dos ganhadores */

            Console.WriteLine("Informe um valor para o prêmio: ");
            double valorImportancia = double.Parse(Console.ReadLine());
            double primeiroGanhador = valorImportancia * 46 / 100;
            double segundoGanhador = valorImportancia * 32 / 100;
            double terceiroGanhador = valorImportancia * 22 / 100;

            Console.WriteLine($"O primeiro ganhador receberá: R$ {primeiroGanhador}, o segundo ganhador: R$ {segundoGanhador} e o terceiro ganhador: R$ {terceiroGanhador}");
            Console.ReadLine();
        }
    }
}
