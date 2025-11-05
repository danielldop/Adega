using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AdegaStockFlow
{
    public class Produto
    {
        //Lista para seguir referencia da original
        List<Produto> produto = new List<Produto>();

        private int id;
        private string nome;
        private string descricao;//Quantidade ml ou L/ gm ou Kg
        private string categoria;// Comida, Bebida
        private string tipo;//Com ou sem alcool e etc...
        private int quantidade;
        private string validade;
        private double valorcompra;
        private double valorvenda;

        public Produto()
        {
            this.id = -1;
            this.nome = null;
            this.descricao = null;
            this.categoria = null;
            this.tipo = null;
            this.quantidade = -1;
            this.validade = null;
            this.valorcompra = -1;
            this.valorvenda = -1;
        }

        //Gets:
        public int getId {get { return id; } }
        public string getNome { get { return nome; } }
        public string getDescricao { get { return descricao; } }
        public string getCategoria { get { return categoria; } }
        public string getTipo { get { return tipo; } }
        public int getQuantidade { get { return quantidade; } }
        public string getValidade { get { return validade; } }
        public double getValorCompra { get { return valorcompra; } }
        public double getValorVenda { get { return valorvenda; } }

        //Sets:
        public int setId(int id) { return this.id = id; }
        public string setNome(string nome) { return this.nome = nome; }
        public string setDescricao(string descricao) { return this.descricao = descricao; }
        public string setCategoria(string categoria) { return this.categoria = categoria; }
        public string setTipo(string tipo) { return this.tipo = tipo; }
        public int setQuantidade(int quantidade) { return this.quantidade = quantidade; }
        public string setValidade(string validade) { return this.validade = validade; }
        public double setValorCompra(double getvalorcompra) { return this.valorcompra = getvalorcompra; }
        public double setValorVenda(double valorvenda) { return this.valorvenda = valorvenda; }

        public Produto CadastrarProduto(int id, string nome,string descricao , string categoria, string tipo, int quantidade, string validade, double valorcompra, double valorvenda)
        {
            Produto produto = new Produto();

            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
            this.categoria = categoria;
            this.tipo = tipo;
            this.quantidade = quantidade;
            this.validade = validade;
            this.valorcompra = valorcompra;
            this.valorvenda = valorvenda;

            return this;
        }

        public Produto DeletarProduto(List<Produto> produto, int id)
        {
            this.produto = produto;

            Produto resultado = produto.FirstOrDefault(p => p.id == id);

            if (resultado != null)
            {
                produto.Remove(resultado);
            }

            return resultado;

        }



    }
}
