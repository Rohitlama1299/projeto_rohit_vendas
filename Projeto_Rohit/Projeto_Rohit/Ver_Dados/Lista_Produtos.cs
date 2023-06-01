using Projeto_Rohit.pt.com.Gvendas.DAO;
using Projeto_Rohit.pt.com.Gvendas.MODEL;
using Projeto_Rohit.pt.com.Gvendas.VIEWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Rohit.Ver_Dados
{
    public partial class Lista_Produtos : Form
    {

        List<Produto> productList = new List<Produto>();


        public Lista_Produtos()
        {
            InitializeComponent();
        }

        #region menu
        private void Inserir_dados_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEncomendas formEncomendas = new FormEncomendas(null, 0);
            formEncomendas.ShowDialog(); ;
        }

        private void listaclientesbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListaClientes form = new ListaClientes();
            form.ShowDialog();
        }

        private void listaProdutosbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void listafornecedorebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lista_Fornecedores form = new Lista_Fornecedores();
            form.ShowDialog();
        }

        private void listaEncomendasbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lista_Encomedas form = new Lista_Encomedas();
            form.ShowDialog();
        }

        private void listaFuncionariosbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lista_Funcionarios form = new Lista_Funcionarios();
            form.ShowDialog();
        }
        #endregion

        private void Lista_Produtos_Load(object sender, EventArgs e)
        {

            productList = SQLProdutos.GetAll();

            //Definir colunas
            // Definição dos nomes das colunas
            listView1.Columns[0].Text = "ID_Produto";
            listView1.Columns[1].Text = "Nome_Produto";
            listView1.Columns[2].Text = "Quantidade";
            listView1.Columns[3].Text = "Preco";


            // Definição das colunas da listview. 
            // NOTA: Os valores percentuais da largura das colunas tem de somar 100
            listView1.Columns[0].Width = (5 * listView1.Width) / 100; // ID -> sempre escondido
            listView1.Columns[1].Width = (10 * listView1.Width) / 100;
            listView1.Columns[2].Width = (15 * listView1.Width) / 100;
            listView1.Columns[3].Width = (15 * listView1.Width) / 100;


            foreach (Produto produto in productList)
            {
                ListViewItem row = new ListViewItem(new[]{
                            produto.Id.ToString(),
                            produto.Nome_produtos,
                            produto.Qtd_produtos.ToString(),
                            produto.Preco.ToString(),
                            

                });

                listView1.Items.Add(row);
            }
        }
    }
}
