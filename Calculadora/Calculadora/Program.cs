using System.Globalization;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite:");
            Console.WriteLine("1. Para usar a Calculadora");
            Console.WriteLine("2. Para saber como funciona");
            int Validacao = int.Parse(Console.ReadLine());
            if (Validacao == 1)
            {
                Console.WriteLine("Calculadora: \n");
                Console.Write("Primeiro Valor: ");
                int nbr1 = int.Parse(Console.ReadLine());
                Operacao Calculo = new Operacao();
                Console.Write("Operação aritmética: ");
                Calculo.calcular = char.Parse(Console.ReadLine());
                Console.Write("Segundo Valor: ");
                int nbr2 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Resultado: " + Calculo.ResultCalculo(nbr1, nbr2) + "\n");
                Console.WriteLine("Reinicie o programa para fazer outro Calculo.");
            }
            else if (Validacao == 2)
            {
                Console.WriteLine();
                Console.WriteLine("Para fazer calculos aritméticos, você deve usar apenas numeros inteiros.");
                Console.WriteLine("As operações aritimeticas são: \n");
                Console.WriteLine("Soma: +");
                Console.WriteLine("Subtração: -");
                Console.WriteLine("Multiplicação: x (certifique-se que a letra está minuscula)");
                Console.WriteLine("Divisão: / \n");
                Console.WriteLine("Exemplo de Calculo: '25 x 4' (Deverá retornar o valor 100) \n");
                Console.WriteLine("Reinicie o Programa para utilizar a Calculadora.");
            }
        }
    }
}