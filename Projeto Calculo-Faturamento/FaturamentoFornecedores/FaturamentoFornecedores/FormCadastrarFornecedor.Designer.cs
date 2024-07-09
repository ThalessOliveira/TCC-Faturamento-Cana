namespace FaturamentoFornecedores
{
    partial class FormCadastrarFornecedor
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
            label1 = new Label();
            txtNome = new TextBox();
            txtEndereco = new TextBox();
            label2 = new Label();
            txtBairro = new TextBox();
            label3 = new Label();
            txtCidade = new TextBox();
            label4 = new Label();
            txtCEP = new TextBox();
            label5 = new Label();
            txtTelefone = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            txtCPF = new TextBox();
            label8 = new Label();
            txtRG = new TextBox();
            label9 = new Label();
            label10 = new Label();
            cboModalidade = new ComboBox();
            btnRetornar = new Button();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 44);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(62, 62);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(193, 23);
            txtNome.TabIndex = 1;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(62, 113);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(193, 23);
            txtEndereco.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 95);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Endereço";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(62, 165);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(193, 23);
            txtBairro.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 147);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "Bairro";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(62, 219);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(193, 23);
            txtCidade.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 201);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 6;
            label4.Text = "Cidade";
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(62, 275);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(193, 23);
            txtCEP.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 257);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 8;
            label5.Text = "CEP";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(316, 53);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(193, 23);
            txtTelefone.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(316, 35);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 10;
            label6.Text = "Telefone";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(316, 113);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(193, 23);
            txtEmail.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(316, 95);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 12;
            label7.Text = "Email";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(316, 165);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(193, 23);
            txtCPF.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(316, 147);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 14;
            label8.Text = "CPF";
            // 
            // txtRG
            // 
            txtRG.Location = new Point(316, 219);
            txtRG.Name = "txtRG";
            txtRG.Size = new Size(193, 23);
            txtRG.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(316, 201);
            label9.Name = "label9";
            label9.Size = new Size(22, 15);
            label9.TabIndex = 16;
            label9.Text = "RG";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(316, 257);
            label10.Name = "label10";
            label10.Size = new Size(70, 15);
            label10.TabIndex = 18;
            label10.Text = "Modalidade";
            // 
            // cboModalidade
            // 
            cboModalidade.FormattingEnabled = true;
            cboModalidade.Items.AddRange(new object[] { "Entrega", "Arrendamento" });
            cboModalidade.Location = new Point(316, 275);
            cboModalidade.Name = "cboModalidade";
            cboModalidade.Size = new Size(193, 23);
            cboModalidade.TabIndex = 19;
            // 
            // btnRetornar
            // 
            btnRetornar.Location = new Point(62, 343);
            btnRetornar.Name = "btnRetornar";
            btnRetornar.Size = new Size(193, 48);
            btnRetornar.TabIndex = 20;
            btnRetornar.Text = "Retornar";
            btnRetornar.UseVisualStyleBackColor = true;
            btnRetornar.Click += button1_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(316, 343);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(193, 48);
            btnSalvar.TabIndex = 21;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormCadastrarFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(btnRetornar);
            Controls.Add(cboModalidade);
            Controls.Add(label10);
            Controls.Add(txtRG);
            Controls.Add(label9);
            Controls.Add(txtCPF);
            Controls.Add(label8);
            Controls.Add(txtEmail);
            Controls.Add(label7);
            Controls.Add(txtTelefone);
            Controls.Add(label6);
            Controls.Add(txtCEP);
            Controls.Add(label5);
            Controls.Add(txtCidade);
            Controls.Add(label4);
            Controls.Add(txtBairro);
            Controls.Add(label3);
            Controls.Add(txtEndereco);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "FormCadastrarFornecedor";
            Text = "FormCadastrarFornecedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private TextBox txtEndereco;
        private Label label2;
        private TextBox txtBairro;
        private Label label3;
        private TextBox txtCidade;
        private Label label4;
        private TextBox txtCEP;
        private Label label5;
        private TextBox txtTelefone;
        private Label label6;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtCPF;
        private Label label8;
        private TextBox txtRG;
        private Label label9;
        private Label label10;
        private ComboBox cboModalidade;
        private Button btnRetornar;
        private Button btnSalvar;
    }
}