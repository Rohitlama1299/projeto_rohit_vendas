using Projeto_Rohit.pt.com.Gvendas.DAO;
using System;
using System.Windows.Forms;
using static Projeto_Rohit.Settings.util;
using System.Drawing;
using Projeto_Rohit.pt.com.Gvendas.MODEL;
using System.Web.UI.WebControls;
using Projeto_Rohit.Ver_Dados;

namespace Projeto_Rohit.pt.com.Gvendas.VIEWS
{
    public partial class FormFornecedores : Form
    {

        public int SQLAction = -1;
        Fornecedore forncedores { get; set; } = null;

        public FormFornecedores(Fornecedore forncedores, int sqlAction)
        {
            SQLAction = sqlAction;
            this.forncedores = forncedores;
            InitializeComponent();
        }
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
            FormProdutos form = new FormProdutos( null,0);
            form.ShowDialog();
        }

        private void Encomendasbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEncomendas form = new FormEncomendas( null,0);
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
                        forncedores.Nome = textBoxNomeForn.Text;
                        forncedores.Email = textBoxEmailForn.Text;
                        forncedores.Morada = textBoxMoradaForn.Text;
                        forncedores.NIF = int.Parse(textBoxNIFForn.Text);
                        forncedores.Cidade = textBoxCidadeForn.Text;
                SQLFornecedore.Insert(forncedores);
                        MessageBox.Show(
                          "Daods inserir",
                          "Dados inseridos",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information
                         );
                Lista_Fornecedores form = new Lista_Fornecedores();
                form.ShowDialog();

            }
                    /* if (Gravar.Enabled == true)
                     {
                         string name = textBoxNomeForn.Text;
                         string morada = textBoxMoradaForn.Text;
                         string email = textBoxEmailForn.Text;
                         string cidade = textBoxCidadeForn.Text;
                         long nif = long.Parse(textBoxNIFForn.Text);
                         forncedores = new MODEL.Fornecedore(name, morada, email,cidade, nif);
                         SQLFornecedore.Insert(forncedores);
                         this.Close();
                     }*/
                    
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

        private void FormFornecedores_Load(object sender, EventArgs e)
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
                   // MessageBox.Show("Operação não permitida.");
                    break;
            }
        }

        #region Utils


        private bool FormDataValidation()
        {
            if (IsEmpty(textBoxNomeForn.Text))
            {
                MessageBox.Show(
                 "Campo nome incorreto, por favor coloque corretamente",
                 "Dados Inválidos",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information
                );

                return false;
            }
            if (!IsEmail(textBoxEmailForn.Text))
            {
                MessageBox.Show(
                 "Campo nome incorreto, por favor coloque corretamente",
                 "Dados Inválidos",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information
                );

                return false;
            }
            if (!IsNumber(textBoxNIFForn.Text))
            {
                MessageBox.Show(
                 "Campo Email incorreto, por favor coloque corretamente",
                 "Dados Inválidos",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information
                );

                return false;
            }
            if (IsEmpty(textBoxMoradaForn.Text))
            {
                MessageBox.Show(
                 "Campo Morada incorreto, por favor coloque corretamente",
                 "Dados Inválidos",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information
                );

                return false;
            }
            




            if (IsEmpty(textBoxCidadeForn.Text))
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

        
        private void FillForm(MODEL.Fornecedore fornecedores)
        {

            //if employee is null jumps out of the method
            if (forncedores == null)
            {

                this.forncedores = new MODEL.Fornecedore();
                ;
                this.forncedores.Nome = textBoxNomeForn.Text;
                this.forncedores.Email = textBoxNomeForn.Text;
                this.forncedores.Cidade = textBoxNomeForn.Text;
                this.forncedores.Morada = textBoxNomeForn.Text;
                this.forncedores.NIF = long.Parse(textBoxNIFForn.Text);

            }

            //fill the employee data
            textBoxNomeForn.Text = this.forncedores.Nome;
            textBoxEmailForn.Text = this.forncedores.Email;
            textBoxCidadeForn.Text = this.forncedores.Cidade;
            textBoxMoradaForn.Text = this.forncedores.Morada;
            textBoxNIFForn.Text = this.forncedores.NIF.ToString();
           
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
            textBoxNomeForn.Enabled = false;
            textBoxEmailForn.Enabled = false;
            textBoxCidadeForn.Enabled = false;
            textBoxMoradaForn.Enabled = false;
            textBoxNIFForn.Enabled = false;
            

        }
        #endregion

        private void ver_dados_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lista_Fornecedores form = new Lista_Fornecedores();
            form.ShowDialog();
        }

        private void fornecedorebtn_Click(object sender, EventArgs e)
        {
            
        }

        private void eliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
