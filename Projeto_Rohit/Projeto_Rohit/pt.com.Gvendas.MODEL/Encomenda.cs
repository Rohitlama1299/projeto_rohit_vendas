using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projeto_Rohit.pt.com.Gvendas.MODEL
{
    public class Encomenda
    {
        public int ID_Encomendas { get; set; }

        public string Nome_de_Encomendas { get; set; }


        public int Qdt_de_Produto{get; set;}

        public Encomenda()
        {

        }

        public Encomenda(int id)
        {
            ID_Encomendas = id;
        }
        public Encomenda(string nome, int quantidade)
        {

            Nome_de_Encomendas = nome;
            Qdt_de_Produto = quantidade;
            
        }

        public Encomenda(int id, string nome, int quantidade)
        {
            ID_Encomendas = id;
            Nome_de_Encomendas = nome;
            Qdt_de_Produto = quantidade;
        }
    }
}
