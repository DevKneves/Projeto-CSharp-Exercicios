using System;
using System.Globalization;

namespace ExercicioDois
{
    class Program
    { 
        static void Main(string[] args)
        {
            Retangulo Re = new Retangulo();
            Console.WriteLine("Entre com a Largura e Altura do retangulo:");
            Re.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Re.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("AREA = " + Re.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + Re.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + Re.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}