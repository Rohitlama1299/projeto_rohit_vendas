using Projeto_Rohit.pt.com.Gvendas.DAO;
using System;
using System.Windows.Forms;
using static Projeto_Rohit.Settings.util;
using System.Drawing;
using Projeto_Rohit.pt.com.Gvendas.MODEL;
using Projeto_Rohit.Ver_Dados;

namespace Projeto_Rohit.pt.com.Gvendas.VIEWS
{
    public partial class FormFuncionarios : Form
    {
        public int SQLAction = -1;
        Funcionario funcionarios { get; set; } = null;

        public FormFuncionarios(int sqlAction, Funcionario funcionarios)
        {
            SQLAction = sqlAction;
            this.funcionarios = funcionarios;
            InitializeComponent();
        }

        private void Gravar_Click(object sender, EventArgs e)
        {
            switch (SQLAction)
            {
                case SQL_INSERT:

                    if (FormDataValidation())
                    {
                        FillForm(null);
                        funcionarios.Nome = textBoxNomeEmp.Text;
                        funcionarios.Email = textBoxEmailEmp.Text;
                        funcionarios.Morada = textBoxMoradaEmp.Text;
                        funcionarios.Telefone = long.Parse(textBoxTelefoneEmp.Text);
                        funcionarios.NIF = long.Parse(textBoxNIF.Text);
                        funcionarios.Estado = textBoxEstado.Text;
                        MessageBox.Show(
                          "Daods inserir",
                          "Dados inseridos",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information
                         );
                        SQLFuncionario.Insert(funcionarios);
                        Lista_Funcionarios form = new Lista_Funcionarios();
                        form.ShowDialog();

                    }
                     break;
                    #region halfpart

                    /*      if (FormDataValidation())
                    {
                        FillForm(null);
                        SQLEmployee.Insert(employee);
                        this.Close();
                    }
                    break;
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

        

        private void FormFuncionarios_Load(object sender, EventArgs e)
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
                    //MessageBox.Show("Operação não permitida.");
                    break;
            }
        }
        #region Utils


        private bool FormDataValidation()
        {
            if (IsEmpty(textBoxNomeEmp.Text))
            {
                MessageBox.Show(
                 "Campo nome incorreto, por favor coloque corretamente",
                 "Dados Inválidos",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information
                );

                return false;
            }
            if (!IsEmail(textBoxEmailEmp.Text))
            {
                MessageBox.Show(
                 "Campo nome incorreto, por favor coloque corretamente",
                 "Dados Inválidos",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information
                );

                return false;
            }
            if (IsEmpty(textBoxEstado.Text))
            {
                MessageBox.Show(
                 "Campo nome incorreto, por favor coloque corretamente",
                 "Dados Inválidos",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information
                );

                return false;
            }
            if (IsEmpty(textBoxMoradaEmp.Text))
            {
                MessageBox.Show(
                 "Campo nome incorreto, por favor coloque corretamente",
                 "Dados Inválidos",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information
                );

                return false;
            }
            if (!IsNumber(textBoxTelefoneEmp.Text) || textBoxTelefoneEmp.TextLength < 9)
            {
                MessageBox.Show(
                 "Campo nome incorreto, por favor coloque corretamente",
                 "Dados Inválidos",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information
                );

                return false;
            }





            if (IsNumber(textBoxNIF.Text))//|| IsNumber(textBoxDepartment.Text)
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

        
        private void FillForm(MODEL.Funcionario  funcionarios)
        {
            if (funcionarios == null)
            {

                this.funcionarios = new MODEL.Funcionario();
                this.funcionarios.Nome = textBoxNomeEmp.Text;
                this.funcionarios.Email = textBoxEmailEmp.Text;
                this.funcionarios.Morada = textBoxMoradaEmp.Text;
                this.funcionarios.Telefone = long.Parse(textBoxTelefoneEmp.Text);
                this.funcionarios.NIF = long.Parse(textBoxNIF.Text);
                this.funcionarios.Estado = textBoxEstado.Text;


            }

            textBoxNomeEmp.Text = this.funcionarios.Nome;
            textBoxEmailEmp.Text = this.funcionarios.Email;
            textBoxMoradaEmp.Text = this.funcionarios.Morada;
            textBoxTelefoneEmp.Text = this.funcionarios.Telefone.ToString();
            textBoxNIF.Text = this.funcionarios.NIF.ToString();
            textBoxEstado.Text = this.funcionarios.Estado;

      
        }

        /*private void FillComboBox()
        {
            this.users = SQLEmployee.GetUserWithoutEmpplyee();
            this.cbName.DataSource = this.users;
            this.cbName.ValueMember = "ID";
            this.cbName.DisplayMember = "Name";
            this.cbName.SelectedIndex = -1;
        }*/

        private void DisableFields()
        {
            textBoxNomeEmp.Enabled = false;
            textBoxEmailEmp.Enabled = false;
            textBoxTelefoneEmp.Enabled = false;
            textBoxMoradaEmp.Enabled = false;
            textBoxEstado.Enabled = false;
            textBoxNIF.Enabled = false;
            
        }
        #endregion
        #region Menu


        private void clientesbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormClientes form = new FormClientes(SQL_INSERT, null);
            form.ShowDialog();
        }

        private void Produtosbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProdutos form = new FormProdutos(null,0);

            form.ShowDialog();

        }

        private void fornecedorebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
           FormFornecedores form = new FormFornecedores(null, 0);
            form.ShowDialog();
        }

        private void Encomendasbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
           FormEncomendas form = new FormEncomendas(null, 0);
            form.ShowDialog();
        }


        #endregion

        private void ver_dados_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lista_Funcionarios form = new Lista_Funcionarios();
            form.ShowDialog();
        }

        private void Funcionariosbtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}

