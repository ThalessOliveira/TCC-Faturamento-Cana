namespace FaturamentoFornecedores
{
    partial class FormSelecionarFornecedor
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
            dgvFornecedores = new DataGridView();
            btnRetornar = new Button();
            btnSelecionar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFornecedores).BeginInit();
            SuspendLayout();
            // 
            // dgvFornecedores
            // 
            dgvFornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFornecedores.Location = new Point(25, 113);
            dgvFornecedores.Name = "dgvFornecedores";
            dgvFornecedores.RowTemplate.Height = 25;
            dgvFornecedores.Size = new Size(747, 315);
            dgvFornecedores.TabIndex = 0;
            // 
            // btnRetornar
            // 
            btnRetornar.Location = new Point(25, 43);
            btnRetornar.Name = "btnRetornar";
            btnRetornar.Size = new Size(175, 51);
            btnRetornar.TabIndex = 1;
            btnRetornar.Text = "Retornar";
            btnRetornar.UseVisualStyleBackColor = true;
            btnRetornar.Click += btnRetornar_Click_1;
            // 
            // btnSelecionar
            // 
            btnSelecionar.Location = new Point(220, 43);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(175, 51);
            btnSelecionar.TabIndex = 2;
            btnSelecionar.Text = "Selecionar o fornecedor";
            btnSelecionar.UseVisualStyleBackColor = true;
            btnSelecionar.Click += btnSelecionar_Click;
            // 
            // FormSelecionarFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSelecionar);
            Controls.Add(btnRetornar);
            Controls.Add(dgvFornecedores);
            Name = "FormSelecionarFornecedor";
            Text = "FormSelecionarFornecedor";
            Load += FormSelecionarFornecedor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFornecedores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvFornecedores;
        private Button btnRetornar;
        private Button btnSelecionar;
    }
}