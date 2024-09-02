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
            cboFornecedor = new ComboBox();
            txtPesquisa = new TextBox();
            limparFiltros = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFornecedores).BeginInit();
            SuspendLayout();
            // 
            // dgvFornecedores
            // 
            dgvFornecedores.BackgroundColor = SystemColors.Control;
            dgvFornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFornecedores.Location = new Point(25, 113);
            dgvFornecedores.Name = "dgvFornecedores";
            dgvFornecedores.RowTemplate.Height = 25;
            dgvFornecedores.Size = new Size(747, 315);
            dgvFornecedores.TabIndex = 0;
            // 
            // btnRetornar
            // 
            btnRetornar.Location = new Point(25, 29);
            btnRetornar.Name = "btnRetornar";
            btnRetornar.Size = new Size(175, 65);
            btnRetornar.TabIndex = 1;
            btnRetornar.Text = "Retornar";
            btnRetornar.UseVisualStyleBackColor = true;
            btnRetornar.Click += btnRetornar_Click_1;
            // 
            // btnSelecionar
            // 
            btnSelecionar.Location = new Point(220, 29);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(175, 65);
            btnSelecionar.TabIndex = 2;
            btnSelecionar.Text = "Selecionar o fornecedor";
            btnSelecionar.UseVisualStyleBackColor = true;
            btnSelecionar.Click += btnSelecionar_Click;
            // 
            // cboFornecedor
            // 
            cboFornecedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFornecedor.FormattingEnabled = true;
            cboFornecedor.Items.AddRange(new object[] { "Entrega", "Arrendamento" });
            cboFornecedor.Location = new Point(418, 71);
            cboFornecedor.Name = "cboFornecedor";
            cboFornecedor.Size = new Size(110, 23);
            cboFornecedor.TabIndex = 3;
            cboFornecedor.SelectedIndexChanged += cboFornecedor_SelectedIndexChanged;
            // 
            // txtPesquisa
            // 
            txtPesquisa.BorderStyle = BorderStyle.None;
            txtPesquisa.Location = new Point(547, 71);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(225, 16);
            txtPesquisa.TabIndex = 4;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // limparFiltros
            // 
            limparFiltros.Location = new Point(418, 29);
            limparFiltros.Name = "limparFiltros";
            limparFiltros.Size = new Size(110, 36);
            limparFiltros.TabIndex = 5;
            limparFiltros.Text = "Limpar";
            limparFiltros.UseVisualStyleBackColor = true;
            limparFiltros.Click += limparFiltros_Click;
            // 
            // FormSelecionarFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(limparFiltros);
            Controls.Add(txtPesquisa);
            Controls.Add(cboFornecedor);
            Controls.Add(btnSelecionar);
            Controls.Add(btnRetornar);
            Controls.Add(dgvFornecedores);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSelecionarFornecedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selecionar Fornecedor";
            Load += FormSelecionarFornecedor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFornecedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvFornecedores;
        private Button btnRetornar;
        private Button btnSelecionar;
        private ComboBox cboFornecedor;
        private TextBox txtPesquisa;
        private Button limparFiltros;
    }
}