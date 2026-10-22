using System;

namespace exercicio_aula
{
    internal class Circunferencia
    {
        public static double PI = Math.PI;

        public static double CalcularCircunferencia(double raio)
        {
            return 2 * PI * raio;
        }

        public static double Volume(double raio)
        {
            return (4.0 / 3.0) * PI * raio * raio * raio;
        }
    }
}