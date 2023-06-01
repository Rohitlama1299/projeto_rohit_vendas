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
using Projeto_Rohit.pt.com.Gvendas.MODEL;
using Projeto_Rohit.pt.com.Gvendas.DAO;

namespace Projeto_Rohit.Ver_Dados
{
    public partial class ListaClientes : Form
    {

        List<Clientes> clienteLista = new List<Clientes>();

     

        public ListaClientes()
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

        private void listaFuncionariosbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lista_Funcionarios form = new Lista_Funcionarios();
            form.ShowDialog();
        }
        #endregion

        private void ListaClientes_Load(object sender, EventArgs e)
        {
            /**
            * 1 identificar as tabelas que iremos utilizar
            * 2 - definir as colunas
            * 3 - preencher as linhas
            *
            * */
       
               

                    clienteLista = SQLCliente.GetAll();

                    //Definir colunas
                    // Definição dos nomes das colunas
                    listView1.Columns[0].Text = "ID_clientes";
                    listView1.Columns[1].Text = "Nome";
                    listView1.Columns[2].Text = "Morada";
                    listView1.Columns[3].Text = "Email";
                    listView1.Columns[4].Text = "Telefone";
                    listView1.Columns[5].Text = "Estados";
                    // Definição das colunas da listview. 
                    // NOTA: Os valores percentuais da largura das colunas tem de somar 100
                    listView1.Columns[0].Width = (5 * listView1.Width) / 100; // ID -> sempre escondido
                    listView1.Columns[1].Width = (10 * listView1.Width) / 100;
                    listView1.Columns[2].Width = (15 * listView1.Width) / 100;
                    listView1.Columns[3].Width = (25 * listView1.Width) / 100;
                    listView1.Columns[4].Width = (15 * listView1.Width) / 100;
                    listView1.Columns[5].Width = (15 * listView1.Width) / 100;

                    foreach (Clientes cliente in clienteLista)
                    {
                        ListViewItem row = new ListViewItem(new[] {
                            cliente.Id.ToString(),
                            cliente.Nome,
                            cliente.Morada,
                            cliente.Email,
                            cliente.Telefone.ToString(),
                            cliente.Estado
                        });
                        listView1.Items.Add(row);
                    }
                    
        }
    }
}
