using System;

namespace ExFixacaoArquivos.Entities
{
    class Product
    {
        public string Nome { get; set; }
        public double PrecoUnitario { get; set; }
        public int Quantidade { get; set; }

        public Product(string nome, double precoUnitario, int quantidade)
        {
            Nome = nome;
            PrecoUnitario = precoUnitario;
            Quantidade = quantidade;
        }

        public double Total()
        {
            return PrecoUnitario * Quantidade;
        }
    }
}
