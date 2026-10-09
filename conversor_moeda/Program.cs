namespace conversor_moeda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a cotação do dolar?");
            double cotacao = double.Parse(Console.ReadLine());

            Console.Write("Qunatos dolares você vai comprar?");
            double quantidade = double.Parse(Console.ReadLine());

            double resultado = ConversorDeMoeda.Converter(cotacao, quantidade);

            Console.WriteLine("Valor a pagar em reais = " + resultado.ToString("F2"));
        }
    }
}
