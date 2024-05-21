using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTres
{
    class Info
    {
        public string Nome;
        public double SalarioBruto;
        public double Impostos;

        public double SalarioLiquido()
        {
            return SalarioBruto - Impostos;
        }
        public void AumentarSalario(double porcentagem)
        { 
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.00);
        }
        public override string ToString()
        {
            return Nome + ", Salário Liquido: $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
