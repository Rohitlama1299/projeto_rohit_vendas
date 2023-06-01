using Projeto_Rohit.pt.com.Gvendas.DAO;
using Projeto_Rohit.pt.com.Gvendas.MODEL;
using Projeto_Rohit.Ver_Dados;
using System;
using System.Data;
using System.Windows.Forms;
using static Projeto_Rohit.Settings.util;

namespace Projeto_Rohit.pt.com.Gvendas.VIEWS
{
    public partial class FormClientes : Form
    {


        public int SQLAction = -1;


        Clientes cliente { get; set; } = null;


        public FormClientes(int sqlAction, Clientes cliente)
        {
         
            this.cliente = cliente;
            SQLAction = sqlAction;
            InitializeComponent();
            
        }

        #region Menu

        private void Produtosbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormProdutos form = new FormProdutos(null,0);

            form.ShowDialog();
        }

        private void fornecedorebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFornecedores form = new FormFornecedores(null,0);
            form.ShowDialog();
        }

        private void Encomendasbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEncomendas form = new FormEncomendas(null,0);
            form.ShowDialog();
        }


        private void Funcionariosbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFuncionarios form = new FormFuncionarios(0, null);
            form.ShowDialog();

        }
        #endregion

        private void Gravar_Click(object sender, EventArgs e)
        {
            
                
                    if (FormDataValidation())
                    {
                        FillForm(null);
                        SQLCliente.Insert(cliente);
                        cliente.Nome = textBoxNome.Text;
                        cliente.Email = textBoxEmail.Text;
                        cliente.Morada = textBoxMorada.Text;
                        cliente.Telefone = int.Parse(textBoxTelefone.Text);
                        cliente.Estado = textBoxEstado.Text;
                        MessageBox.Show(
                          "Daods inserir",
                          "Dados inseridos",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information
                         );
                    FormEncomendas formEncomendas = new FormEncomendas(null, 0);
                    formEncomendas.ShowDialog();

                #region halfpart

                /* 
            case SQL_UPDATE:
                buttonAction.Text = "Editar";
                if (FormDataValidation())
                {
                    Employee employee = new Employee(this.employee.Cod, cbName.Text, textBoxDepartment.Text, textBoxPhoneNo.Text);

                    SQLEmployee.Update(employee);
                    this.Close();
                }
                break;
            case SQL_DELETE:
                buttonAction.Text = "Remover";
                DisableFields();
                FillForm(employee);

                var result = MessageBox.Show($"Deseja mesmo eliminar o registo Cod[{employee.Cod}] - {employee.Name}", "Confirmação de remover", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    SQLEmployee.Delete(employee);
                }
                this.Close();
                break;
            default:

                MessageBox.Show("Ação não permitida", "Por favor faça uma ação que seja permitida.",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                break;
                */
                #endregion
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
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
                    MessageBox.Show("Operação não permitida.");
                    break;
            }
            

        }
        #region Utils


        private bool FormDataValidation()
        {
            if (IsEmpty(textBoxNome.Text))
            {
                MessageBox.Show(
                 "Campo nome incorreto, por favor coloque corretamente",
                 "Dados Inválidos",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information
                );

                return false;
            }

            if (!IsEmail(textBoxEmail.Text))
            {
                MessageBox.Show(
                 "Campo email incorreto, por favor coloque corretamente",
                 "Dados Inválidos",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information
                );

                return false;
            }

            if (IsEmpty(textBoxEstado.Text))
            {
                MessageBox.Show(
                 "Campo Estado incorreto, por favor coloque corretamente",
                 "Dados Inválidos",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information
                );

                return false;
            }

            if (IsEmpty(textBoxMorada.Text))
            {
                MessageBox.Show(
                 "Campo morada incorreto, por favor coloque corretamente",
                 "Dados Inválidos",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information
                );

                return false;
            }





            if (!IsNumber(textBoxTelefone.Text))//|| IsNumber(textBoxDepartment.Text)
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


        private void FillForm(Clientes cliente)
        {

            //if employee is null jumps out of the method
            if (cliente == null)
            {

                this.cliente = new Clientes();

                this.cliente.Nome = textBoxNome.Text;
                this.cliente.Email = textBoxEmail.Text;
                this.cliente.Morada = textBoxMorada.Text;
                this.cliente.Estado = textBoxEstado.Text;
                this.cliente.Telefone = long.Parse(textBoxTelefone.Text);
                

            }

            //fill the employee data
            textBoxNome.Text = this.cliente.Nome;
            textBoxEmail.Text = this.cliente.Email;
            textBoxMorada.Text = this.cliente.Morada;
            textBoxEstado.Text = this.cliente.Estado;
            textBoxTelefone.Text = this.cliente.Telefone.ToString();
        }
        private void DisableFields()
        {
            textBoxNome.Enabled = false;
            textBoxEmail.Enabled = false;
            textBoxMorada.Enabled = false;
            textBoxTelefone.Enabled = false;
            textBoxEstado.Enabled = false;


        }
        #endregion
        private void ver_dados_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListaClientes form = new ListaClientes();
            form.ShowDialog();
        }

        private void clientesbtn_Click(object sender, EventArgs e)
        {

        }

        private void Alterar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
