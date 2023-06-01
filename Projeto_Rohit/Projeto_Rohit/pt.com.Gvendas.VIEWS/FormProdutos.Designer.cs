namespace Projeto_Rohit.pt.com.Gvendas.VIEWS
{
    partial class FormProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProdutos));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Gravar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.textBoxQtd = new System.Windows.Forms.TextBox();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.textBoxNomeProdutos = new System.Windows.Forms.TextBox();
            this.Email_1 = new System.Windows.Forms.Label();
            this.Telefone_1 = new System.Windows.Forms.Label();
            this.Nome_1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ver_dados = new Guna.UI2.WinForms.Guna2Button();
            this.Funcionariosbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Encomendasbtn = new Guna.UI2.WinForms.Guna2Button();
            this.fornecedorebtn = new Guna.UI2.WinForms.Guna2Button();
            this.Produtosbtn = new Guna.UI2.WinForms.Guna2Button();
            this.clientesbtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(155, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 48);
            this.panel2.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "Info de Produtos";
            // 
            // Gravar
            // 
            this.Gravar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gravar.Location = new System.Drawing.Point(615, 225);
            this.Gravar.Name = "Gravar";
            this.Gravar.Size = new System.Drawing.Size(133, 30);
            this.Gravar.TabIndex = 33;
            this.Gravar.Text = "Gravar";
            this.Gravar.UseVisualStyleBackColor = true;
            this.Gravar.Click += new System.EventHandler(this.Gravar_Click);
            // 
            // eliminar
            // 
            this.eliminar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar.Location = new System.Drawing.Point(464, 225);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(133, 30);
            this.eliminar.TabIndex = 22;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            // 
            // textBoxQtd
            // 
            this.textBoxQtd.Location = new System.Drawing.Point(465, 99);
            this.textBoxQtd.Name = "textBoxQtd";
            this.textBoxQtd.Size = new System.Drawing.Size(122, 20);
            this.textBoxQtd.TabIndex = 31;
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(201, 157);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(156, 20);
            this.textBoxPreco.TabIndex = 29;
            // 
            // textBoxNomeProdutos
            // 
            this.textBoxNomeProdutos.Location = new System.Drawing.Point(198, 99);
            this.textBoxNomeProdutos.Name = "textBoxNomeProdutos";
            this.textBoxNomeProdutos.Size = new System.Drawing.Size(156, 20);
            this.textBoxNomeProdutos.TabIndex = 28;
            // 
            // Email_1
            // 
            this.Email_1.AutoSize = true;
            this.Email_1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_1.Location = new System.Drawing.Point(201, 133);
            this.Email_1.Name = "Email_1";
            this.Email_1.Size = new System.Drawing.Size(54, 21);
            this.Email_1.TabIndex = 25;
            this.Email_1.Text = "Preço";
            // 
            // Telefone_1
            // 
            this.Telefone_1.AutoSize = true;
            this.Telefone_1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone_1.Location = new System.Drawing.Point(461, 73);
            this.Telefone_1.Name = "Telefone_1";
            this.Telefone_1.Size = new System.Drawing.Size(128, 21);
            this.Telefone_1.TabIndex = 24;
            this.Telefone_1.Text = "Qtd de Produto";
            // 
            // Nome_1
            // 
            this.Nome_1.AutoSize = true;
            this.Nome_1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome_1.Location = new System.Drawing.Point(197, 73);
            this.Nome_1.Name = "Nome_1";
            this.Nome_1.Size = new System.Drawing.Size(152, 21);
            this.Nome_1.TabIndex = 23;
            this.Nome_1.Text = "Nome de Produtos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 107);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.ver_dados);
            this.panel1.Controls.Add(this.Funcionariosbtn);
            this.panel1.Controls.Add(this.Encomendasbtn);
            this.panel1.Controls.Add(this.fornecedorebtn);
            this.panel1.Controls.Add(this.Produtosbtn);
            this.panel1.Controls.Add(this.clientesbtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 522);
            this.panel1.TabIndex = 21;
            // 
            // ver_dados
            // 
            this.ver_dados.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ver_dados.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ver_dados.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ver_dados.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ver_dados.FillColor = System.Drawing.Color.Transparent;
            this.ver_dados.FocusedColor = System.Drawing.Color.Black;
            this.ver_dados.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.ver_dados.ForeColor = System.Drawing.Color.Black;
            this.ver_dados.Location = new System.Drawing.Point(10, 133);
            this.ver_dados.Name = "ver_dados";
            this.ver_dados.Size = new System.Drawing.Size(135, 45);
            this.ver_dados.TabIndex = 75;
            this.ver_dados.Text = "Ver Dados";
            this.ver_dados.Click += new System.EventHandler(this.ver_dados_Click);
            // 
            // Funcionariosbtn
            // 
            this.Funcionariosbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Funcionariosbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Funcionariosbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Funcionariosbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Funcionariosbtn.FillColor = System.Drawing.Color.Transparent;
            this.Funcionariosbtn.FocusedColor = System.Drawing.Color.Black;
            this.Funcionariosbtn.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.Funcionariosbtn.ForeColor = System.Drawing.Color.Black;
            this.Funcionariosbtn.Location = new System.Drawing.Point(12, 407);
            this.Funcionariosbtn.Name = "Funcionariosbtn";
            this.Funcionariosbtn.Size = new System.Drawing.Size(130, 45);
            this.Funcionariosbtn.TabIndex = 53;
            this.Funcionariosbtn.Text = "Funcionarios";
            this.Funcionariosbtn.Click += new System.EventHandler(this.Funcionariosbtn_Click_1);
            // 
            // Encomendasbtn
            // 
            this.Encomendasbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Encomendasbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Encomendasbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Encomendasbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Encomendasbtn.FillColor = System.Drawing.Color.Transparent;
            this.Encomendasbtn.FocusedColor = System.Drawing.Color.Black;
            this.Encomendasbtn.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.Encomendasbtn.ForeColor = System.Drawing.Color.Black;
            this.Encomendasbtn.Location = new System.Drawing.Point(12, 356);
            this.Encomendasbtn.Name = "Encomendasbtn";
            this.Encomendasbtn.Size = new System.Drawing.Size(130, 45);
            this.Encomendasbtn.TabIndex = 51;
            this.Encomendasbtn.Text = "Encomendas";
            this.Encomendasbtn.Click += new System.EventHandler(this.Encomendasbtn_Click_1);
            // 
            // fornecedorebtn
            // 
            this.fornecedorebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.fornecedorebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.fornecedorebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.fornecedorebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.fornecedorebtn.FillColor = System.Drawing.Color.Transparent;
            this.fornecedorebtn.FocusedColor = System.Drawing.Color.Black;
            this.fornecedorebtn.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.fornecedorebtn.ForeColor = System.Drawing.Color.Black;
            this.fornecedorebtn.Location = new System.Drawing.Point(15, 319);
            this.fornecedorebtn.Name = "fornecedorebtn";
            this.fornecedorebtn.Size = new System.Drawing.Size(130, 45);
            this.fornecedorebtn.TabIndex = 50;
            this.fornecedorebtn.Text = "Fornecedores";
            this.fornecedorebtn.Click += new System.EventHandler(this.fornecedorebtn_Click_1);
            // 
            // Produtosbtn
            // 
            this.Produtosbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Produtosbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Produtosbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Produtosbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Produtosbtn.FillColor = System.Drawing.Color.Transparent;
            this.Produtosbtn.FocusedColor = System.Drawing.Color.Black;
            this.Produtosbtn.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.Produtosbtn.ForeColor = System.Drawing.Color.Black;
            this.Produtosbtn.Location = new System.Drawing.Point(15, 268);
            this.Produtosbtn.Name = "Produtosbtn";
            this.Produtosbtn.Size = new System.Drawing.Size(130, 45);
            this.Produtosbtn.TabIndex = 49;
            this.Produtosbtn.Text = "Produtos";
            this.Produtosbtn.Click += new System.EventHandler(this.Produtosbtn_Click);
            // 
            // clientesbtn
            // 
            this.clientesbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clientesbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clientesbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clientesbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clientesbtn.FillColor = System.Drawing.Color.Transparent;
            this.clientesbtn.FocusedColor = System.Drawing.Color.Black;
            this.clientesbtn.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.clientesbtn.ForeColor = System.Drawing.Color.Black;
            this.clientesbtn.Location = new System.Drawing.Point(15, 225);
            this.clientesbtn.Name = "clientesbtn";
            this.clientesbtn.Size = new System.Drawing.Size(130, 45);
            this.clientesbtn.TabIndex = 48;
            this.clientesbtn.Text = "Clientes";
            this.clientesbtn.Click += new System.EventHandler(this.clientesbtn_Click);
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 522);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Gravar);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.textBoxQtd);
            this.Controls.Add(this.textBoxPreco);
            this.Controls.Add(this.textBoxNomeProdutos);
            this.Controls.Add(this.Email_1);
            this.Controls.Add(this.Telefone_1);
            this.Controls.Add(this.Nome_1);
            this.Controls.Add(this.panel1);
            this.Name = "FormProdutos";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.FormProdutos_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Gravar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.TextBox textBoxQtd;
        private System.Windows.Forms.TextBox textBoxPreco;
        private System.Windows.Forms.TextBox textBoxNomeProdutos;
        private System.Windows.Forms.Label Email_1;
        private System.Windows.Forms.Label Telefone_1;
        private System.Windows.Forms.Label Nome_1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button Funcionariosbtn;
        private Guna.UI2.WinForms.Guna2Button Encomendasbtn;
        private Guna.UI2.WinForms.Guna2Button fornecedorebtn;
        private Guna.UI2.WinForms.Guna2Button Produtosbtn;
        private Guna.UI2.WinForms.Guna2Button clientesbtn;
        private Guna.UI2.WinForms.Guna2Button ver_dados;
    }
}