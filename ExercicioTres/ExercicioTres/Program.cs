using System.Globalization;

namespace ExercicioTres
{
    class Program
    {
        static void Main(string[] args)
        {
            Info Infor = new Info();
            Console.Write("Nome: ");
            Infor.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            Infor.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Impostos: ");
            Infor.Impostos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Funcionario: " + Infor);
            Console.WriteLine();
            Console.Write("Deseja aumentar o salário em qual porcentagem? (somente numeros)");
            double porcen = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Infor.AumentarSalario(porcen);
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + Infor);
        }
    }
}