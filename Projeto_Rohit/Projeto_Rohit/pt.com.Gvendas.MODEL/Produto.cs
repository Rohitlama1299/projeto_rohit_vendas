using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Rohit.pt.com.Gvendas.MODEL
{
    public class Produto
    {
        public int Id { get; set; }
        public String Nome_produtos { get; set; }
        public int Qtd_produtos { get; set; }
        public int Preco { get; set; }

        public Produto()
        {

        }

        public Produto(int id)
        {
            Id = id;
        }
        public Produto(string nome, int qtd_pro, int  preco)
        {

            Nome_produtos = nome;
            Qtd_produtos = qtd_pro;
            Preco = preco;

        }

        public Produto(int id, string nome, int qtd_pro, int preco)
        {
            Id = id;
            Nome_produtos = nome;
            Qtd_produtos = qtd_pro;
            Preco = preco;

        }
    }
}
