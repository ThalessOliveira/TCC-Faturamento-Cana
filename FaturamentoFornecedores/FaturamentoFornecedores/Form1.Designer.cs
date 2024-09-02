namespace FaturamentoFornecedores
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCadastrarFornecedor = new Button();
            btnSelecionarFornecedor = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // btnCadastrarFornecedor
            // 
            btnCadastrarFornecedor.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            btnCadastrarFornecedor.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrarFornecedor.Location = new Point(265, 76);
            btnCadastrarFornecedor.Name = "btnCadastrarFornecedor";
            btnCadastrarFornecedor.Size = new Size(263, 63);
            btnCadastrarFornecedor.TabIndex = 0;
            btnCadastrarFornecedor.Text = "Cadastrar Fornecedor";
            btnCadastrarFornecedor.UseVisualStyleBackColor = true;
            btnCadastrarFornecedor.Click += btnCadastrarFornecedor_Click;
            // 
            // btnSelecionarFornecedor
            // 
            btnSelecionarFornecedor.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnSelecionarFornecedor.Location = new Point(265, 177);
            btnSelecionarFornecedor.Name = "btnSelecionarFornecedor";
            btnSelecionarFornecedor.Size = new Size(263, 63);
            btnSelecionarFornecedor.TabIndex = 1;
            btnSelecionarFornecedor.Text = "Selecionar Fornecedor";
            btnSelecionarFornecedor.UseVisualStyleBackColor = true;
            btnSelecionarFornecedor.Click += btnSelecionarFornecedor_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Transparent;
            btnSair.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnSair.Location = new Point(293, 354);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(200, 50);
            btnSair.TabIndex = 2;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSair);
            Controls.Add(btnSelecionarFornecedor);
            Controls.Add(btnCadastrarFornecedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Faturamento Fornecedores";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCadastrarFornecedor;
        private Button btnSelecionarFornecedor;
        private Button btnSair;
    }
}
