using Exercicio01;
using System;

class Program
{
    static void Main(String[] args)
    {
        Produto P = new Produto();
        Console.WriteLine("Entre com os dados do Produto");
        Console.WriteLine("Nome: ");
        P.Nome = Console.ReadLine();
        Console.WriteLine("Preço :");
        P.Valor = double.Parse(Console.ReadLine());
        Console.WriteLine("Quantidade no Estoque: ");
        P.Qnd = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");
        Console.WriteLine(P);
        Console.WriteLine("\n");
        Console.WriteLine("Digite o numero de Produtos a serem adicionados no Estoque: ");
        int add = int.Parse(Console.ReadLine());
        P.AdicionarProduto(add);
        Console.WriteLine("Dados atualizados: " + P);
        Console.WriteLine("Digite o numero de Produtos a serem removidos do Estoque: ");
        int remove = int.Parse(Console.ReadLine());
        P.RemoverProduto(remove);
        Console.WriteLine("Dados atualizados: " + P);
    }
}