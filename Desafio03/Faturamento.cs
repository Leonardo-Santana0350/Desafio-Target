using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTarget.Desafio03
{
    internal class Faturamento
    {
        public int Dia { get; set; }
        public double FaturamentoDiario { get; set; }

        public Faturamento(int dia, double faturamentoDiario)
        {
            Dia = dia;
            FaturamentoDiario = faturamentoDiario;
        }
    }
}
