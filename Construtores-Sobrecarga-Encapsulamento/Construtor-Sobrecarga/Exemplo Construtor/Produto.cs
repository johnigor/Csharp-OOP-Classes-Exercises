using System.Globalization;

namespace Exemplo_Construtor
{
    //Este exercício é o mesmo que o da pasta "Construtores" porém utilizando sobrecarga.
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //Construtor com 3 parâmetros
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Sobrecarga (outro construtor para ter mais opções de parâmetros)
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 0; //Essa linha é dispensável pois atributos numéricos já recebem o valor "0"
        }

        public Produto()
        {
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}

