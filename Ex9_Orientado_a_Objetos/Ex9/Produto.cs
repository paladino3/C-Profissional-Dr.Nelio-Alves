using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

namespace Ex9_Orientado_a_Objetos
{
    class Produto
    {

        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public double ValorTotalEmEstoque()
        {
           double precoTotal = this.Quantidade * this.Preco;
            return precoTotal;
        }

        public void AdicionarProdutos(int quantidade)
        {
            this.Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            this.Quantidade -= quantidade;
        }


        public override string ToString()
        {
            return "Dados atualizados:  {0}, $ {1}, {2} unidades, Total: ${3} "+ this.Nome + this.Preco.ToString("F2", CultureInfo.InvariantCulture) + this.Quantidade + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        public void AtualizarDados()
        {
            Console.WriteLine("Dados atualizados: {0}, $ {1}, {2} unidades, Total: ${3} ", this.Nome, this.Preco.ToString("F2", CultureInfo.InvariantCulture), this.Quantidade, ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}
