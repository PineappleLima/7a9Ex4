using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7a9Ex5
{
    public class Produto
    {
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public bool Disponivel { get; set; }

        public Produto(string nome, string categoria, double preco, int quantidade, bool disponivel)
        {
            Nome = nome;
            Categoria = categoria;
            Preco = preco;
            Quantidade = quantidade;
            Disponivel = disponivel;
        }

        public string ExibirProduto()
        {
            return "Nome: " + Nome +
                   "\nCategoria: " + Categoria +
                   "\nPreço: " + Preco.ToString("F2") + " €" +
                   "\nQuantidade em stock: " + Quantidade +
                   "\nDisponível: " + (Disponivel ? "Sim" : "Não");
        }
    }
}

