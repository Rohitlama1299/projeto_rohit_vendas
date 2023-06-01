using Projeto_Rohit.pt.com.Gvendas.DAO;
using System;
using System.Windows.Forms;
using static Projeto_Rohit.Settings.util;
using System.Drawing;
using System.Xml.Linq;
using Projeto_Rohit.pt.com.Gvendas.MODEL;
using Projeto_Rohit.Ver_Dados;
using System.Collections.Generic;

namespace Projeto_Rohit.pt.com.Gvendas.VIEWS
{
    public partial class FormProdutos : Form
    {
        public int SQLAction = -1;
        Produto produtos { get; set; } = null;

        //IEnumerable<Fornecedore> fornecedores;

        public FormProdutos(Produto produtos,int sqlAction)
        {
            SQLAction = sqlAction;
            this.produtos = produtos;
            InitializeComponent();
        }
        #region Menu
        private void fornecedorebtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
           FormFornecedores form = new FormFornecedores(null, 0);
            form.ShowDialog();
        }

        private void Encomendasbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
          FormEncomendas form = new FormEncomendas(null, 0);
            form.ShowDialog();
        }

        private void Funcionariosbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormFuncionarios form = new FormFuncionarios(0, null);
            form.ShowDialog();
        }

        private void clientesbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormClientes form = new FormClientes(SQL_INSERT, null);
            form.ShowDialog();
        }
        #endregion

       /* private void fillcomboBox()
        {
            this.fornecedores = SQLFornecedore.GetAll();
            this.comboBoxfornecedore.DataSource = this.fornecedores;
            this.comboBoxfornecedore.ValueMember = "Id";
            this.comboBoxfornecedore.DisplayMember = "Nome";
            this.comboBoxfornecedore.SelectedIndex = -1;
        }*/
        private void Gravar_Click(object sender, EventArgs e)
        {

         
           
               
                    if (FormDataValidation())
                    {
                        FillForm(null);
                        //Fornecedore fornecedore = (Fornecedore)comboBoxfornecedore.SelectedItem;
                        //Fornecedore fornecedoreFilled = SQLFornecedore.GetById(fornecedore.Id);

                //  Produto produtos = new Produto(-1, fornecedoreFilled.Nome,Convert.ToInt32(fornecedoreFilled.NIF);
                        produtos.Nome_produtos = textBoxNomeProdutos.Text;
                        produtos.Qtd_produtos = int.Parse(textBoxQtd.Text);
                        produtos.Preco = int.Parse(textBoxPreco.Text);
                    
                         SQLProdutos.Insert(produtos);
                MessageBox.Show(
                 "Daods inserir",
                 "Dados inseridos",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information
                );
                Lista_Produtos form = new Lista_Produtos();
                form.ShowDialog();

            }

            /*
            if (Gravar.Enabled == true)
            {
                string name = textBoxNomeProdutos.Text;
                int Qtd = int.Parse(textBoxQtd.Text);
                int nif = int.Parse(textBoxPreco.Text);
                produtos = new MODEL.Produto(name,Qtd, nif);
                SQLProdutos.Insert(produtos);
                this.Close();
            }
            break;*/
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

        private void FormProdutos_Load(object sender, EventArgs e)
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
            if (IsEmpty(textBoxNomeProdutos.Text)) 
            {
                MessageBox.Show(
                 "Campo nome incorreto, por favor coloque corretamente",
                 "Dados Inválidos",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information
                );
                
                return false;
            }
            

            if (!IsNumber(textBoxPreco.Text))
            {
                MessageBox.Show(
                 "Campo preco incorreto, por favor coloque corretamente",
                 "Dados Inválidos",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information
                );
                
                return false;
            }
           

            if (!IsNumber(textBoxQtd.Text))
            {
                MessageBox.Show(
                "Campo Quantidade incorreto, por favor coloque corretamente",
                "Dados Inválidos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
               );
               
                return false;
            }
          

            return true;
        }

        
        private void FillForm(Produto produtos)
        {

            
            if (produtos == null)
            {

                this.produtos = new Produto();

                this.produtos.Nome_produtos = textBoxNomeProdutos.Text;
                this.produtos.Qtd_produtos =int.Parse(textBoxQtd.Text);
                this.produtos.Preco = int.Parse(textBoxPreco.Text);

            }

            
            textBoxNomeProdutos.Text = this.produtos.Nome_produtos;
            textBoxPreco.Text = this.produtos.Preco.ToString();
            textBoxQtd.Text = this.produtos.Qtd_produtos.ToString();
        }

        
       
        private void DisableFields()
        {
            textBoxNomeProdutos.Enabled = false;
            textBoxPreco.Enabled = false;
            textBoxQtd.Enabled = false;
        }
        #endregion

        private void ver_dados_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lista_Produtos form = new Lista_Produtos();
            form.ShowDialog();
        }

        private void Produtosbtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
