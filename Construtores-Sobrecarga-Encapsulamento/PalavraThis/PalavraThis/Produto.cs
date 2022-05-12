using System;

namespace PalavraThis
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //Construtor padrão
        public Produto()
        {
            Quantidade = 10;
        }

        // Construtor com dois parâmetros utilizando o "this" para reaproveitar os dados(quantidade) do construtor padrão
        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }

        //Construtor com três parâmetros utilizando o "this" para reaproveitar os dados (nome, preco) do construtor já nessa classe
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }
    }
}
