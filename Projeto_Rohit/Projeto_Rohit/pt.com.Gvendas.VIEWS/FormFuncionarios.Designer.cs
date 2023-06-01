namespace Projeto_Rohit.pt.com.Gvendas.VIEWS
{
    partial class FormFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFuncionarios));
            this.Alterar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.EmpDGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Gravar = new System.Windows.Forms.Button();
            this.textBoxNomeEmp = new System.Windows.Forms.TextBox();
            this.Nome_1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ver_dados = new Guna.UI2.WinForms.Guna2Button();
            this.Funcionariosbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Encomendasbtn = new Guna.UI2.WinForms.Guna2Button();
            this.fornecedorebtn = new Guna.UI2.WinForms.Guna2Button();
            this.Produtosbtn = new Guna.UI2.WinForms.Guna2Button();
            this.clientesbtn = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.textBoxTelefoneEmp = new System.Windows.Forms.TextBox();
            this.textBoxMoradaEmp = new System.Windows.Forms.TextBox();
            this.textBoxEmailEmp = new System.Windows.Forms.TextBox();
            this.Morada_1 = new System.Windows.Forms.Label();
            this.Estado_1 = new System.Windows.Forms.Label();
            this.Email_1 = new System.Windows.Forms.Label();
            this.Telefone_1 = new System.Windows.Forms.Label();
            this.textBoxNIF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.eliminar = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDGV)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Alterar
            // 
            this.Alterar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alterar.Location = new System.Drawing.Point(701, 266);
            this.Alterar.Name = "Alterar";
            this.Alterar.Size = new System.Drawing.Size(133, 30);
            this.Alterar.TabIndex = 50;
            this.Alterar.Text = "Alterar";
            this.Alterar.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.EmpDGV);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(161, 316);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(695, 196);
            this.panel3.TabIndex = 49;
            // 
            // EmpDGV
            // 
            this.EmpDGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.EmpDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpDGV.Location = new System.Drawing.Point(3, 37);
            this.EmpDGV.Name = "EmpDGV";
            this.EmpDGV.Size = new System.Drawing.Size(689, 150);
            this.EmpDGV.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Lista de Funcionarios";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(155, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 48);
            this.panel2.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "Info de Funcionarios ";
            // 
            // Gravar
            // 
            this.Gravar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gravar.Location = new System.Drawing.Point(553, 266);
            this.Gravar.Name = "Gravar";
            this.Gravar.Size = new System.Drawing.Size(133, 30);
            this.Gravar.TabIndex = 46;
            this.Gravar.Text = "Gravar";
            this.Gravar.UseVisualStyleBackColor = true;
            this.Gravar.Click += new System.EventHandler(this.Gravar_Click);
            // 
            // textBoxNomeEmp
            // 
            this.textBoxNomeEmp.Location = new System.Drawing.Point(198, 99);
            this.textBoxNomeEmp.Name = "textBoxNomeEmp";
            this.textBoxNomeEmp.Size = new System.Drawing.Size(156, 20);
            this.textBoxNomeEmp.TabIndex = 43;
            // 
            // Nome_1
            // 
            this.Nome_1.AutoSize = true;
            this.Nome_1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome_1.Location = new System.Drawing.Point(197, 73);
            this.Nome_1.Name = "Nome_1";
            this.Nome_1.Size = new System.Drawing.Size(118, 21);
            this.Nome_1.TabIndex = 40;
            this.Nome_1.Text = "Nome de Emp";
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
            this.panel1.TabIndex = 38;
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
            this.ver_dados.Location = new System.Drawing.Point(15, 133);
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
            this.Funcionariosbtn.Location = new System.Drawing.Point(15, 404);
            this.Funcionariosbtn.Name = "Funcionariosbtn";
            this.Funcionariosbtn.Size = new System.Drawing.Size(130, 45);
            this.Funcionariosbtn.TabIndex = 59;
            this.Funcionariosbtn.Text = "Funcionarios";
            this.Funcionariosbtn.Click += new System.EventHandler(this.Funcionariosbtn_Click);
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
            this.Encomendasbtn.Location = new System.Drawing.Point(12, 353);
            this.Encomendasbtn.Name = "Encomendasbtn";
            this.Encomendasbtn.Size = new System.Drawing.Size(130, 45);
            this.Encomendasbtn.TabIndex = 57;
            this.Encomendasbtn.Text = "Encomendas";
            this.Encomendasbtn.Click += new System.EventHandler(this.Encomendasbtn_Click);
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
            this.fornecedorebtn.Location = new System.Drawing.Point(15, 316);
            this.fornecedorebtn.Name = "fornecedorebtn";
            this.fornecedorebtn.Size = new System.Drawing.Size(130, 45);
            this.fornecedorebtn.TabIndex = 56;
            this.fornecedorebtn.Text = "Fornecedores";
            this.fornecedorebtn.Click += new System.EventHandler(this.fornecedorebtn_Click);
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
            this.Produtosbtn.Location = new System.Drawing.Point(15, 265);
            this.Produtosbtn.Name = "Produtosbtn";
            this.Produtosbtn.Size = new System.Drawing.Size(130, 45);
            this.Produtosbtn.TabIndex = 55;
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
            this.clientesbtn.Location = new System.Drawing.Point(15, 222);
            this.clientesbtn.Name = "clientesbtn";
            this.clientesbtn.Size = new System.Drawing.Size(130, 45);
            this.clientesbtn.TabIndex = 54;
            this.clientesbtn.Text = "Clientes";
            this.clientesbtn.Click += new System.EventHandler(this.clientesbtn_Click);
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
            // textBoxEstado
            // 
            this.textBoxEstado.Location = new System.Drawing.Point(463, 157);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.Size = new System.Drawing.Size(122, 20);
            this.textBoxEstado.TabIndex = 60;
            // 
            // textBoxTelefoneEmp
            // 
            this.textBoxTelefoneEmp.Location = new System.Drawing.Point(463, 99);
            this.textBoxTelefoneEmp.Name = "textBoxTelefoneEmp";
            this.textBoxTelefoneEmp.Size = new System.Drawing.Size(122, 20);
            this.textBoxTelefoneEmp.TabIndex = 59;
            // 
            // textBoxMoradaEmp
            // 
            this.textBoxMoradaEmp.Location = new System.Drawing.Point(199, 222);
            this.textBoxMoradaEmp.Name = "textBoxMoradaEmp";
            this.textBoxMoradaEmp.Size = new System.Drawing.Size(156, 20);
            this.textBoxMoradaEmp.TabIndex = 58;
            // 
            // textBoxEmailEmp
            // 
            this.textBoxEmailEmp.Location = new System.Drawing.Point(199, 157);
            this.textBoxEmailEmp.Name = "textBoxEmailEmp";
            this.textBoxEmailEmp.Size = new System.Drawing.Size(156, 20);
            this.textBoxEmailEmp.TabIndex = 57;
            // 
            // Morada_1
            // 
            this.Morada_1.AutoSize = true;
            this.Morada_1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Morada_1.Location = new System.Drawing.Point(199, 195);
            this.Morada_1.Name = "Morada_1";
            this.Morada_1.Size = new System.Drawing.Size(68, 21);
            this.Morada_1.TabIndex = 55;
            this.Morada_1.Text = "Morada";
            // 
            // Estado_1
            // 
            this.Estado_1.AutoSize = true;
            this.Estado_1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estado_1.Location = new System.Drawing.Point(459, 133);
            this.Estado_1.Name = "Estado_1";
            this.Estado_1.Size = new System.Drawing.Size(62, 21);
            this.Estado_1.TabIndex = 54;
            this.Estado_1.Text = "Estado";
            // 
            // Email_1
            // 
            this.Email_1.AutoSize = true;
            this.Email_1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_1.Location = new System.Drawing.Point(198, 133);
            this.Email_1.Name = "Email_1";
            this.Email_1.Size = new System.Drawing.Size(51, 21);
            this.Email_1.TabIndex = 53;
            this.Email_1.Text = "Email";
            // 
            // Telefone_1
            // 
            this.Telefone_1.AutoSize = true;
            this.Telefone_1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone_1.Location = new System.Drawing.Point(459, 73);
            this.Telefone_1.Name = "Telefone_1";
            this.Telefone_1.Size = new System.Drawing.Size(74, 21);
            this.Telefone_1.TabIndex = 52;
            this.Telefone_1.Text = "Telefone";
            // 
            // textBoxNIF
            // 
            this.textBoxNIF.Location = new System.Drawing.Point(463, 221);
            this.textBoxNIF.Name = "textBoxNIF";
            this.textBoxNIF.Size = new System.Drawing.Size(122, 20);
            this.textBoxNIF.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(459, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 21);
            this.label3.TabIndex = 61;
            this.label3.Text = "NIF";
            // 
            // eliminar
            // 
            this.eliminar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar.Location = new System.Drawing.Point(400, 265);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(133, 30);
            this.eliminar.TabIndex = 63;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            // 
            // FormFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 522);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.textBoxNIF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEstado);
            this.Controls.Add(this.textBoxTelefoneEmp);
            this.Controls.Add(this.textBoxMoradaEmp);
            this.Controls.Add(this.textBoxEmailEmp);
            this.Controls.Add(this.Morada_1);
            this.Controls.Add(this.Estado_1);
            this.Controls.Add(this.Email_1);
            this.Controls.Add(this.Telefone_1);
            this.Controls.Add(this.Alterar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Gravar);
            this.Controls.Add(this.textBoxNomeEmp);
            this.Controls.Add(this.Nome_1);
            this.Controls.Add(this.panel1);
            this.Name = "FormFuncionarios";
            this.Text = "Funcionarios";
            this.Load += new System.EventHandler(this.FormFuncionarios_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Alterar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView EmpDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Gravar;
        private System.Windows.Forms.TextBox textBoxNomeEmp;
        private System.Windows.Forms.Label Nome_1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxEstado;
        private System.Windows.Forms.TextBox textBoxTelefoneEmp;
        private System.Windows.Forms.TextBox textBoxMoradaEmp;
        private System.Windows.Forms.TextBox textBoxEmailEmp;
        private System.Windows.Forms.Label Morada_1;
        private System.Windows.Forms.Label Estado_1;
        private System.Windows.Forms.Label Email_1;
        private System.Windows.Forms.Label Telefone_1;
        private System.Windows.Forms.TextBox textBoxNIF;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button Funcionariosbtn;
        private Guna.UI2.WinForms.Guna2Button Encomendasbtn;
        private Guna.UI2.WinForms.Guna2Button fornecedorebtn;
        private Guna.UI2.WinForms.Guna2Button Produtosbtn;
        private Guna.UI2.WinForms.Guna2Button clientesbtn;
        private System.Windows.Forms.Button eliminar;
        private Guna.UI2.WinForms.Guna2Button ver_dados;
    }
}