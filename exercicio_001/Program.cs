namespace exercicio_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Digite um número inteiro: ");
            num = int.Parse(Console.ReadLine());

            if (num < 0)

            {
                Console.WriteLine("Número negatativo! ");
            }
            else
            {
                Console.WriteLine("Número positivo!");
            }
        }
             
           
    }
}
