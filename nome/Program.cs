namespace nome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados do Usuario");
            Console.WriteLine();
            Console.WriteLine("Digite o seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine(nome);
            Console.WriteLine("Digite sua idade");
            int idade = int .Parse(Console.ReadLine());
            Console.Write("Digite sua altura");
            float altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite um caractere");
            char character = char.Parse(Console.ReadLine());

            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
    }
}
