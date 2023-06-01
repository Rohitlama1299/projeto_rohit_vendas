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
    public partial class Lista_Encomedas : Form
    {

        List<Encomenda> encomendaList = new List<Encomenda>();
        public Lista_Encomedas()
        {
            InitializeComponent();
        }

        #region menu
        private void listaclientesbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListaClientes form = new ListaClientes();
            form.ShowDialog();
        }

        private void listaProdutosbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lista_Produtos form = new Lista_Produtos();
            form.ShowDialog();
        }

        private void listafornecedorebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lista_Fornecedores form = new Lista_Fornecedores();
            form.ShowDialog();
        }

        private void listaEncomendasbtn_Click(object sender, EventArgs e)
        {

        }

        private void listaFuncionariosbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lista_Funcionarios form = new Lista_Funcionarios();
            form.ShowDialog();
        }

        private void Inserir_dados_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEncomendas formEncomendas = new FormEncomendas(null, 0);
            formEncomendas.ShowDialog(); ;
        }
        #endregion

        private void Lista_Encomedas_Load(object sender, EventArgs e)
        {

            encomendaList = SQLEncomenda.GetAll();

            //Definir colunas
            // Definição dos nomes das colunas
            listView1.Columns[0].Text = "ID_Encomenda";
            listView1.Columns[1].Text = "Nom_Encomenda";
            listView1.Columns[2].Text = "Quantidade";

            // Definição das colunas da listview. 
            // NOTA: Os valores percentuais da largura das colunas tem de somar 100
            listView1.Columns[0].Width = (5 * listView1.Width) / 100; // ID -> sempre escondido
            listView1.Columns[1].Width = (10 * listView1.Width) / 100;
            listView1.Columns[2].Width = (15 * listView1.Width) / 100;

            foreach (Encomenda encomenda in encomendaList)
            {
                ListViewItem row = new ListViewItem(new[]{
                            encomenda.ID_Encomendas.ToString(),
                            encomenda.Nome_de_Encomendas,
                            encomenda.Qdt_de_Produto.ToString()

                });

                listView1.Items.Add(row);
            }
        }
    }

}
