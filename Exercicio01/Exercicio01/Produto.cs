using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio01
{
    class Produto
    {
        public string Nome;
        public int Qnd;
        public double Valor;

        public double ValorTotal()
        {
            return Qnd * Valor;
        }
         public void AdicionarProduto(int qnd)
        {
            Qnd = Qnd + qnd;
        }
        public void RemoverProduto(int remove)
        {
            Qnd = Qnd - remove;
        }
        public override string ToString()
        {
            return "Nome: " + Nome + ", Valor: R$" 
                + Valor.ToString("F2", CultureInfo.InvariantCulture) 
                + ", Quantidade: " + Qnd + ", Total: " + ValorTotal();
        }
    }
}
