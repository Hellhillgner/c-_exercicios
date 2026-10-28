using System.Xml.Serialization;

namespace demo_soma_de_valores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int soma = 0;

            Console.WriteLine("Quantos núemros inteiros você vai digitar? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Valor" + i + ": ");
                int valor = int.Parse(Console.ReadLine());

                soma = soma + valor;

            }

            Console.WriteLine("Soma = " + soma);
        }
    }
}
