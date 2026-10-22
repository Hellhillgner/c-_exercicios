using System;

namespace exercicio_aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Circunferencia.CalcularCircunferencia(raio);
            double volume = Circunferencia.Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2"));
            Console.WriteLine("Volume: " + volume.ToString("F2"));
            Console.WriteLine("Valor de PI: " + Circunferencia.PI.ToString("F2"));
        }
    }
}