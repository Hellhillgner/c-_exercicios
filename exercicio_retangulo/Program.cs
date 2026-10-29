using Exercicio;
using System;
using System.Globalization;

namespace exercicio_retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retangulo:");

            retangulo.Largura = double.Parse(
                Console.ReadLine(),
                CultureInfo.InvariantCulture
            );

            retangulo.Altura = double.Parse(
                Console.ReadLine(),
                CultureInfo.InvariantCulture
            );

            Console.WriteLine();

            Console.WriteLine("AREA = " + retangulo.Area().ToString("F2"));
            Console.WriteLine("PERIMETRO = " + retangulo.Perimetro().ToString("F2"));
            Console.WriteLine("DIAGONAL = " + retangulo.Diagonal().ToString("F2"));
        }
    }
}