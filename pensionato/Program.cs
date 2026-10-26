namespace pensionato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];
            string[] emails = new string[10];

            Console.WriteLine("Quantos quartos serão alugados?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nAluguel #{i}: ");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quartos: ");
                int quarto = int.Parse(Console.ReadLine());

                nomes[quarto] = nome;
                emails[quarto] = email;

            }

            Console.WriteLine("\nQuartos ocupados: ");

            for (int i = 0; i < 10; i++)
            {
                if (nomes[i] != null)
                {
                    Console.WriteLine($"{i}: {nomes[i]}, {emails[i]}");
                }
            }
        }
    }
}
