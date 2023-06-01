using Projeto_Rohit.pt.com.Gvendas.DAO;
using Projeto_Rohit.pt.com.Gvendas.MODEL;
using Projeto_Rohit.Ver_Dados;
using System;
using System.Windows.Forms;
using static Projeto_Rohit.Settings.util;

namespace Projeto_Rohit.pt.com.Gvendas.VIEWS
{
    public partial class FormEncomendas : Form
    {

        public int SQLAction = -1;
        Encomenda encomendas { get; set; } = null;

        public FormEncomendas(Encomenda encomendas, int sqlAction)
        {
            this.encomendas = encomendas;
            this.SQLAction = sqlAction;
            InitializeComponent();
        }



        #region Menu
        private void fornecedorebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFornecedores form = new FormFornecedores(null, 0);
            form.ShowDialog();
        }

        private void Produtosbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProdutos form = new FormProdutos(null, 0);
            form.ShowDialog();

        }

        private void Funcionariosbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFuncionarios form = new FormFuncionarios(0, null);
            form.ShowDialog();

        }

        private void clientesbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormClientes form = new FormClientes(SQL_INSERT, null);
            form.ShowDialog();
        }


        #endregion


        private void Gravar_Click(object sender, EventArgs e)
        {
            if (FormDataValidation())
            {
                FillForm(null);
                encomendas.Nome_de_Encomendas = textBoxNomeEnco.Text;
                encomendas.Qdt_de_Produto = int.Parse(textBoxQtdEnco.Text);
                SQLEncomenda.Insert(encomendas);
                MessageBox.Show(
                  "Daods inserir",
                  "Dados inseridos",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information
                 );
                
                Lista_Encomedas form = new Lista_Encomedas();
                form.ShowDialog();
                
            }

        }
        private void Encomendas_Load(object sender, EventArgs e)
        {
            switch (SQLAction)
            {
                case SQL_INSERT:
                    Gravar.Text = "Inserir";
                    break;
                case SQL_UPDATE:
                    Gravar.Text = "Editar";
                    break;
                case SQL_DELETE:
                    Gravar.Text = "Remover";
                    break;
                default:
                    //  MessageBox.Show("Operação não permitida.");
                    break;
            }
        }
        #region Utils


        private bool FormDataValidation()
        {
            if (IsEmpty(textBoxNomeEnco.Text))
            {
                MessageBox.Show(
                 "Campo nome incorreto, por favor coloque corretamente",
                 "Dados Inválidos",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information
                );

                return false;
            }



            if (!IsNumber(textBoxQtdEnco.Text))
            {
                MessageBox.Show(
                "Campo Departamento incorreto, por favor coloque corretamente",
                "Dados Inválidos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
               );

                return false;
            }


            return true;
        }


        private void FillForm(MODEL.Encomenda encomendas)
        {

            //if employee is null jumps out of the method
            if (encomendas == null)
            {

                this.encomendas = new MODEL.Encomenda();

                this.encomendas.Nome_de_Encomendas = textBoxNomeEnco.Text;
                this.encomendas.Qdt_de_Produto = int.Parse(textBoxQtdEnco.Text);

            }

            //fill the employee data
            textBoxNomeEnco.Text = this.encomendas.Nome_de_Encomendas;
            textBoxQtdEnco.Text = this.encomendas.Qdt_de_Produto.ToString();

        }



        private void DisableFields()
        {
            textBoxNomeEnco.Enabled = false;
            textBoxQtdEnco.Enabled = false;



        }

        #endregion

        private void ver_dados_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lista_Encomedas form = new Lista_Encomedas();
            form.ShowDialog();
        }

        private void Encomendasbtn_Click(object sender, EventArgs e)
        {
           
        }
    }
}
