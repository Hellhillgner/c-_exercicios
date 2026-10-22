
using System;

namespace numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos numeros deseja digitar? ");
            int n = int.Parse(Console.ReadLine());

            int[] numeros = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite o {i + 1} numero: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numeros);

            Console.WriteLine("\nNumeros em ordem crescente:");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
