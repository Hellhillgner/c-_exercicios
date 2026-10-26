using System;
using System.Globalization;

namespace exercicio_fixacao_novo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variáveis do seu exercício
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            // Exibição dos dados na tela
            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2:F2}");
            Console.WriteLine(); // Linha em branco

            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine(); // Linha em branco

            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");

            // Exibe o seu texto atualizado com ponto em vez de vírgula
            Console.WriteLine("Separador decimal invariante culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));

            // Mantém a janela aberta na tela
            Console.ReadLine();
        }
    }
}
