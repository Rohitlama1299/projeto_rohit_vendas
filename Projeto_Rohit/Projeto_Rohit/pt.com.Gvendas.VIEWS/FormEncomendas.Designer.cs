namespace Projeto_Rohit.pt.com.Gvendas.VIEWS
{
    partial class FormEncomendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEncomendas));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Gravar = new System.Windows.Forms.Button();
            this.textBoxQtdEnco = new System.Windows.Forms.TextBox();
            this.textBoxNomeEnco = new System.Windows.Forms.TextBox();
            this.Telefone_1 = new System.Windows.Forms.Label();
            this.Nome_1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ver_dados = new Guna.UI2.WinForms.Guna2Button();
            this.Funcionariosbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Encomendasbtn = new Guna.UI2.WinForms.Guna2Button();
            this.fornecedorebtn = new Guna.UI2.WinForms.Guna2Button();
            this.Produtosbtn = new Guna.UI2.WinForms.Guna2Button();
            this.clientesbtn = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.eliminar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(247, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "Info de Encomendas";
            // 
            // Gravar
            // 
            this.Gravar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gravar.Location = new System.Drawing.Point(551, 193);
            this.Gravar.Name = "Gravar";
            this.Gravar.Size = new System.Drawing.Size(133, 30);
            this.Gravar.TabIndex = 46;
            this.Gravar.Text = "Gravar";
            this.Gravar.UseVisualStyleBackColor = true;
            this.Gravar.Click += new System.EventHandler(this.Gravar_Click);
            // 
            // textBoxQtdEnco
            // 
            this.textBoxQtdEnco.Location = new System.Drawing.Point(465, 99);
            this.textBoxQtdEnco.Name = "textBoxQtdEnco";
            this.textBoxQtdEnco.Size = new System.Drawing.Size(122, 20);
            this.textBoxQtdEnco.TabIndex = 45;
            // 
            // textBoxNomeEnco
            // 
            this.textBoxNomeEnco.Location = new System.Drawing.Point(198, 99);
            this.textBoxNomeEnco.Name = "textBoxNomeEnco";
            this.textBoxNomeEnco.Size = new System.Drawing.Size(156, 20);
            this.textBoxNomeEnco.TabIndex = 43;
            // 
            // Telefone_1
            // 
            this.Telefone_1.AutoSize = true;
            this.Telefone_1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone_1.Location = new System.Drawing.Point(461, 73);
            this.Telefone_1.Name = "Telefone_1";
            this.Telefone_1.Size = new System.Drawing.Size(128, 21);
            this.Telefone_1.TabIndex = 41;
            this.Telefone_1.Text = "Qtd de Produto";
            // 
            // Nome_1
            // 
            this.Nome_1.AutoSize = true;
            this.Nome_1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome_1.Location = new System.Drawing.Point(197, 73);
            this.Nome_1.Name = "Nome_1";
            this.Nome_1.Size = new System.Drawing.Size(179, 21);
            this.Nome_1.TabIndex = 40;
            this.Nome_1.Text = "Nome de Encomendas";
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
            this.ver_dados.Location = new System.Drawing.Point(18, 142);
            this.ver_dados.Name = "ver_dados";
            this.ver_dados.Size = new System.Drawing.Size(135, 45);
            this.ver_dados.TabIndex = 52;
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
            this.Funcionariosbtn.Location = new System.Drawing.Point(15, 405);
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
            this.Encomendasbtn.Location = new System.Drawing.Point(12, 354);
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
            this.fornecedorebtn.Location = new System.Drawing.Point(15, 317);
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
            this.Produtosbtn.Location = new System.Drawing.Point(15, 266);
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
            this.clientesbtn.Location = new System.Drawing.Point(15, 223);
            this.clientesbtn.Name = "clientesbtn";
            this.clientesbtn.Size = new System.Drawing.Size(130, 45);
            this.clientesbtn.TabIndex = 54;
            this.clientesbtn.Text = "Clientes";
            this.clientesbtn.Click += new System.EventHandler(this.clientesbtn_Click_1);
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
            // eliminar
            // 
            this.eliminar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar.Location = new System.Drawing.Point(402, 193);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(133, 30);
            this.eliminar.TabIndex = 51;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            // 
            // FormEncomendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 522);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Gravar);
            this.Controls.Add(this.textBoxQtdEnco);
            this.Controls.Add(this.textBoxNomeEnco);
            this.Controls.Add(this.Telefone_1);
            this.Controls.Add(this.Nome_1);
            this.Controls.Add(this.panel1);
            this.Name = "FormEncomendas";
            this.Text = "Encomendas";
            this.Load += new System.EventHandler(this.Encomendas_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Gravar;
        private System.Windows.Forms.TextBox textBoxQtdEnco;
        private System.Windows.Forms.TextBox textBoxNomeEnco;
        private System.Windows.Forms.Label Telefone_1;
        private System.Windows.Forms.Label Nome_1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button Funcionariosbtn;
        private Guna.UI2.WinForms.Guna2Button Encomendasbtn;
        private Guna.UI2.WinForms.Guna2Button fornecedorebtn;
        private Guna.UI2.WinForms.Guna2Button Produtosbtn;
        private Guna.UI2.WinForms.Guna2Button clientesbtn;
        private System.Windows.Forms.Button eliminar;
        private Guna.UI2.WinForms.Guna2Button ver_dados;
    }
}