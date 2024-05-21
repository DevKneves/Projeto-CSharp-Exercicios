using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Operacao
    {
        public char calcular;

        public int ResultCalculo(int a, int b)
        {
            if (calcular == '+')
                return a + b;
            else if (calcular == '-')
                return a - b;
            else if (calcular == 'x')
                return a * b;
            else if (calcular == '/')
                return a / b;
            else
            {
                Console.WriteLine("Você digitou uma operação aritmética invalida.");
                return 0;
            }
        }
    }
}
