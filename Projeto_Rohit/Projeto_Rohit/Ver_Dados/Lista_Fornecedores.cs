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
    public partial class Lista_Fornecedores : Form
    {

        List<Fornecedore> fornecedoreList = new List<Fornecedore>();
        public Lista_Fornecedores()
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
            this.Hide();
            Lista_Produtos form = new Lista_Produtos();
            form.ShowDialog();
        }

        private void listafornecedorebtn_Click(object sender, EventArgs e)
        {
            
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


private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lista_Fornecedores_Load(object sender, EventArgs e)
        {

            fornecedoreList = SQLFornecedore.GetAll();

            //Definir colunas
            // Definição dos nomes das colunas
            listView1.Columns[0].Text = "ID_Fornecedore";
            listView1.Columns[1].Text = "Nome_Fornecedore";
            listView1.Columns[2].Text = "Email";
            listView1.Columns[3].Text = "Morada";
            listView1.Columns[4].Text = "Cidade";
            listView1.Columns[5].Text = "NIF";

            // Definição das colunas da listview. 
            // NOTA: Os valores percentuais da largura das colunas tem de somar 100
            listView1.Columns[0].Width = (5 * listView1.Width) / 100; // ID -> sempre escondido
            listView1.Columns[1].Width = (10 * listView1.Width) / 100;
            listView1.Columns[2].Width = (15 * listView1.Width) / 100;
            listView1.Columns[3].Width = (15 * listView1.Width) / 100;
            listView1.Columns[4].Width = (15 * listView1.Width) / 100;
            listView1.Columns[5].Width = (15 * listView1.Width) / 100;

            foreach (Fornecedore fornecedore in fornecedoreList)
            {
                ListViewItem row = new ListViewItem(new[]{
                            fornecedore.Id.ToString(),
                            fornecedore.Nome,
                            fornecedore.Email,
                            fornecedore.Morada,
                            fornecedore.Cidade,
                            fornecedore.NIF.ToString()

                });

                listView1.Items.Add(row);
            }
    }

}
}
