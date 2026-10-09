using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace conversor_moeda
{
    internal class ConversorDeMoeda
    {
        public static double IOF = 6.0;
        
        public static double Converter(double cotacao, double quantidade)
        {

        double valor_reais = cotacao * quantidade;
        double valor_iof = valor_reais * IOF / 100.0;

           return valor_reais +valor_iof;
        }
    }
}
