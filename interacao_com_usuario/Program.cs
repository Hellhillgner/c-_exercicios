using System;
using System.Globalization;

namespace interacao_com_usuario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Leitura dos dados individuais
            Console.WriteLine("Entre com o seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            // Alterado de float para double para maior compatibilidade com InvariantCulture
            double produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            

            // Lê a linha inteira e divide as palavras pelos espaços
            string[] vet = Console.ReadLine().Split(' ');

            // Armazena cada parte extraída do vetor nas variáveis corretas
            string ultimoNome = vet[0];
            int idade = int.Parse(vet[1]);
            // Alterado de float para double
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            // 3. Exibição dos resultados no console
            Console.WriteLine("\n--- DADOS DIGITADOS ---");
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(produto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

            // Mantém a janela do console aberta para você ver o resultado
            Console.ReadLine();
        }
    }
}
