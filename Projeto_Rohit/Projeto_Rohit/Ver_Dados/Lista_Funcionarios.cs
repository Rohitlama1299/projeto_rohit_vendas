using Projeto_Rohit.pt.com.Gvendas.MODEL;
using Projeto_Rohit.pt.com.Gvendas.DAO;
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
    public partial class Lista_Funcionarios : Form
    {

        List<Funcionario> funcionariosList = new List<Funcionario>();

        public Lista_Funcionarios()
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
            this.Hide();
            Lista_Encomedas form = new Lista_Encomedas();
            form.ShowDialog();
        }

        private void Inserir_dados_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEncomendas formEncomendas = new FormEncomendas(null, 0);
            formEncomendas.ShowDialog(); ;
        }
        #endregion

        private void Lista_Funcionarios_Load(object sender, EventArgs e)
        {


            funcionariosList = SQLFuncionario.GetAll();

            //Definir colunas
            // Definição dos nomes das colunas
            listView1.Columns[0].Text = "ID_Funcionarios";
            listView1.Columns[1].Text = "Nome";
            listView1.Columns[2].Text = "Morada";
            listView1.Columns[3].Text = "Email";
            listView1.Columns[4].Text = "Telefone";
            listView1.Columns[5].Text = "Estados";
            listView1.Columns[6].Text = "Nif";
            // Definição das colunas da listview. 
            // NOTA: Os valores percentuais da largura das colunas tem de somar 100
            listView1.Columns[0].Width = (5 * listView1.Width) / 100; // ID -> sempre escondido
            listView1.Columns[1].Width = (10 * listView1.Width) / 100;
            listView1.Columns[2].Width = (15 * listView1.Width) / 100;
            listView1.Columns[3].Width = (25 * listView1.Width) / 100;
            listView1.Columns[4].Width = (15 * listView1.Width) / 100;
            listView1.Columns[5].Width = (15 * listView1.Width) / 100;
            listView1.Columns[6].Width = (15 * listView1.Width) / 100;

            foreach (Funcionario funcionario in funcionariosList)
            {
                ListViewItem row = new ListViewItem(new[] {
                            funcionario.Id.ToString(),
                            funcionario.Nome,
                            funcionario.Morada,
                            funcionario.Email,
                            funcionario.Telefone.ToString(),
                            funcionario.NIF.ToString(),
                            funcionario.Estado
                        });
                listView1.Items.Add(row);
            }

        }
    }
}
