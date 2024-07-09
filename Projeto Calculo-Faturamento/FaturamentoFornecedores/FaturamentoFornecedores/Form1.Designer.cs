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
            btnCadastrarFornecedor.Location = new Point(50, 30);
            btnCadastrarFornecedor.Name = "btnCadastrarFornecedor";
            btnCadastrarFornecedor.Size = new Size(200, 50);
            btnCadastrarFornecedor.TabIndex = 0;
            btnCadastrarFornecedor.Text = "Cadastrar Fornecedor";
            btnCadastrarFornecedor.UseVisualStyleBackColor = true;
            btnCadastrarFornecedor.Click += btnCadastrarFornecedor_Click;
            // 
            // btnSelecionarFornecedor
            // 
            btnSelecionarFornecedor.Location = new Point(50, 100);
            btnSelecionarFornecedor.Name = "btnSelecionarFornecedor";
            btnSelecionarFornecedor.Size = new Size(200, 50);
            btnSelecionarFornecedor.TabIndex = 1;
            btnSelecionarFornecedor.Text = "Selecionar Fornecedor";
            btnSelecionarFornecedor.UseVisualStyleBackColor = true;
            btnSelecionarFornecedor.Click += btnSelecionarFornecedor_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(50, 170);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(200, 50);
            btnSair.TabIndex = 2;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSair);
            Controls.Add(btnSelecionarFornecedor);
            Controls.Add(btnCadastrarFornecedor);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCadastrarFornecedor;
        private Button btnSelecionarFornecedor;
        private Button btnSair;
    }
}
