using System;

namespace exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 10 – Elabore um algoritmo que calcule a área da superfície de um paralelepípedo 
                Área: 2*(ab + bc + ac) */

            Console.WriteLine("Digite um número para o comprimento de um paralelepípedo: ");
            double comprimentoParalelepipedo = double.Parse(Console.ReadLine());

            Console.WriteLine("Agora, digite um número para a largura desse paralelepípedo: ");
            double larguraParalelepipedo = double.Parse(Console.ReadLine());

            Console.WriteLine("Por fim, digite um número para a altura desse paralelepípedo: ");
            double alturaParalelepipedo = double.Parse(Console.ReadLine());

            double areaParalelepipedo = 2 * (comprimentoParalelepipedo * larguraParalelepipedo + larguraParalelepipedo * alturaParalelepipedo + comprimentoParalelepipedo * alturaParalelepipedo);

            Console.WriteLine($"A área do paralelepípedo é: {areaParalelepipedo}");

            Console.ReadLine();
        }
    }
}
