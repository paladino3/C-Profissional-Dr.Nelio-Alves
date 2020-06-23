using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Ex13_Orientado_a_Objetos
{
    class Produto
    {

        private string _nome { get; set; }
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }
        public Produto()
        {
        }

        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }

            }
        }
        /*
                public double Preco
                {
                    get { return _preco; }
                }

                public int Quantidade
                {
                    get { return _quantidade; }
                }
        */

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

        /*
                public override string ToString()
                {
                    return "Dados atualizados:  {0}, $ {1}, {2} unidades, Total: ${3} " + this.Nome + this.Preco.ToString("F2", CultureInfo.InvariantCulture) + this.Quantidade + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
                }
                */
        public void AtualizarDados()
        {
            Console.WriteLine("Dados atualizados: {0}, $ {1}, {2} unidades, Total: ${3} ", this._nome, this.Preco.ToString("F2", CultureInfo.InvariantCulture), this.Quantidade, ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
