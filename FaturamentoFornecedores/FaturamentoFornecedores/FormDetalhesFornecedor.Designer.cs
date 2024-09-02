namespace FaturamentoFornecedores
{
    partial class FormDetalhesFornecedor
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
            tabControlDetalhes = new TabControl();
            tabPageHistorico = new TabPage();
            btnGerarArquivo = new Button();
            dgvHistorico = new DataGridView();
            tabPageEntrega = new TabPage();
            btnSalvarEntrega = new Button();
            label4 = new Label();
            txtATREntrega = new TextBox();
            label3 = new Label();
            txtToneladasEntrega = new TextBox();
            label2 = new Label();
            txtAnoEntrega = new TextBox();
            label1 = new Label();
            txtMesEntrega = new TextBox();
            tabPageArrendamento = new TabPage();
            btnSalvarArrendamento = new Button();
            label7 = new Label();
            txtATR = new TextBox();
            label6 = new Label();
            txtToneladasPorAlqueire = new TextBox();
            label5 = new Label();
            txtAlqueires = new TextBox();
            btnRetornar = new Button();
            tabControlDetalhes.SuspendLayout();
            tabPageHistorico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).BeginInit();
            tabPageEntrega.SuspendLayout();
            tabPageArrendamento.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlDetalhes
            // 
            tabControlDetalhes.Controls.Add(tabPageHistorico);
            tabControlDetalhes.Controls.Add(tabPageEntrega);
            tabControlDetalhes.Controls.Add(tabPageArrendamento);
            tabControlDetalhes.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tabControlDetalhes.Location = new Point(2, 1);
            tabControlDetalhes.Name = "tabControlDetalhes";
            tabControlDetalhes.SelectedIndex = 0;
            tabControlDetalhes.Size = new Size(802, 401);
            tabControlDetalhes.TabIndex = 0;
            // 
            // tabPageHistorico
            // 
            tabPageHistorico.BackColor = SystemColors.ControlDark;
            tabPageHistorico.Controls.Add(btnGerarArquivo);
            tabPageHistorico.Controls.Add(dgvHistorico);
            tabPageHistorico.Location = new Point(4, 31);
            tabPageHistorico.Name = "tabPageHistorico";
            tabPageHistorico.Padding = new Padding(3);
            tabPageHistorico.Size = new Size(794, 366);
            tabPageHistorico.TabIndex = 0;
            tabPageHistorico.Text = "Histórico";
            // 
            // btnGerarArquivo
            // 
            btnGerarArquivo.Font = new Font("Roboto", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGerarArquivo.Location = new Point(533, 16);
            btnGerarArquivo.Name = "btnGerarArquivo";
            btnGerarArquivo.Size = new Size(249, 70);
            btnGerarArquivo.TabIndex = 1;
            btnGerarArquivo.Text = "Gerar Relatório";
            btnGerarArquivo.UseVisualStyleBackColor = true;
            btnGerarArquivo.Click += btnGerarArquivo_Click;
            // 
            // dgvHistorico
            // 
            dgvHistorico.BackgroundColor = SystemColors.Control;
            dgvHistorico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorico.Location = new Point(9, 92);
            dgvHistorico.Name = "dgvHistorico";
            dgvHistorico.RowTemplate.Height = 25;
            dgvHistorico.Size = new Size(776, 323);
            dgvHistorico.TabIndex = 0;
            dgvHistorico.CellContentClick += dgvHistorico_CellContentClick;
            // 
            // tabPageEntrega
            // 
            tabPageEntrega.BackColor = SystemColors.ControlDark;
            tabPageEntrega.Controls.Add(btnSalvarEntrega);
            tabPageEntrega.Controls.Add(label4);
            tabPageEntrega.Controls.Add(txtATREntrega);
            tabPageEntrega.Controls.Add(label3);
            tabPageEntrega.Controls.Add(txtToneladasEntrega);
            tabPageEntrega.Controls.Add(label2);
            tabPageEntrega.Controls.Add(txtAnoEntrega);
            tabPageEntrega.Controls.Add(label1);
            tabPageEntrega.Controls.Add(txtMesEntrega);
            tabPageEntrega.Location = new Point(4, 31);
            tabPageEntrega.Name = "tabPageEntrega";
            tabPageEntrega.Padding = new Padding(3);
            tabPageEntrega.Size = new Size(794, 366);
            tabPageEntrega.TabIndex = 1;
            tabPageEntrega.Text = "Informações de Entrega";
            // 
            // btnSalvarEntrega
            // 
            btnSalvarEntrega.Location = new Point(237, 298);
            btnSalvarEntrega.Name = "btnSalvarEntrega";
            btnSalvarEntrega.Size = new Size(305, 51);
            btnSalvarEntrega.TabIndex = 8;
            btnSalvarEntrega.Text = "Salvar";
            btnSalvarEntrega.UseVisualStyleBackColor = true;
            btnSalvarEntrega.Click += btnSalvarEntrega_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(237, 213);
            label4.Name = "label4";
            label4.Size = new Size(48, 22);
            label4.TabIndex = 7;
            label4.Text = "ATR";
            // 
            // txtATREntrega
            // 
            txtATREntrega.BorderStyle = BorderStyle.None;
            txtATREntrega.Location = new Point(237, 238);
            txtATREntrega.Name = "txtATREntrega";
            txtATREntrega.Size = new Size(305, 22);
            txtATREntrega.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(237, 156);
            label3.Name = "label3";
            label3.Size = new Size(97, 22);
            label3.TabIndex = 5;
            label3.Text = "Toneladas";
            // 
            // txtToneladasEntrega
            // 
            txtToneladasEntrega.BorderStyle = BorderStyle.None;
            txtToneladasEntrega.Location = new Point(237, 181);
            txtToneladasEntrega.Name = "txtToneladasEntrega";
            txtToneladasEntrega.Size = new Size(305, 22);
            txtToneladasEntrega.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 99);
            label2.Name = "label2";
            label2.Size = new Size(113, 22);
            label2.TabIndex = 3;
            label2.Text = "Ano entrega";
            // 
            // txtAnoEntrega
            // 
            txtAnoEntrega.BorderStyle = BorderStyle.None;
            txtAnoEntrega.Location = new Point(237, 124);
            txtAnoEntrega.Name = "txtAnoEntrega";
            txtAnoEntrega.Size = new Size(305, 22);
            txtAnoEntrega.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(237, 42);
            label1.Name = "label1";
            label1.Size = new Size(115, 22);
            label1.TabIndex = 1;
            label1.Text = "Mês entrega";
            // 
            // txtMesEntrega
            // 
            txtMesEntrega.BorderStyle = BorderStyle.None;
            txtMesEntrega.Location = new Point(237, 67);
            txtMesEntrega.Name = "txtMesEntrega";
            txtMesEntrega.Size = new Size(305, 22);
            txtMesEntrega.TabIndex = 0;
            // 
            // tabPageArrendamento
            // 
            tabPageArrendamento.BackColor = SystemColors.ControlDark;
            tabPageArrendamento.Controls.Add(btnSalvarArrendamento);
            tabPageArrendamento.Controls.Add(label7);
            tabPageArrendamento.Controls.Add(txtATR);
            tabPageArrendamento.Controls.Add(label6);
            tabPageArrendamento.Controls.Add(txtToneladasPorAlqueire);
            tabPageArrendamento.Controls.Add(label5);
            tabPageArrendamento.Controls.Add(txtAlqueires);
            tabPageArrendamento.ForeColor = SystemColors.ControlText;
            tabPageArrendamento.Location = new Point(4, 31);
            tabPageArrendamento.Name = "tabPageArrendamento";
            tabPageArrendamento.Size = new Size(794, 366);
            tabPageArrendamento.TabIndex = 2;
            tabPageArrendamento.Text = "Informações de Arrendamento";
            // 
            // btnSalvarArrendamento
            // 
            btnSalvarArrendamento.Location = new Point(239, 297);
            btnSalvarArrendamento.Name = "btnSalvarArrendamento";
            btnSalvarArrendamento.Size = new Size(305, 52);
            btnSalvarArrendamento.TabIndex = 14;
            btnSalvarArrendamento.Text = "Salvar";
            btnSalvarArrendamento.UseVisualStyleBackColor = true;
            btnSalvarArrendamento.Click += btnSalvarArrendamento_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(239, 176);
            label7.Name = "label7";
            label7.Size = new Size(48, 22);
            label7.TabIndex = 13;
            label7.Text = "ATR";
            // 
            // txtATR
            // 
            txtATR.BorderStyle = BorderStyle.None;
            txtATR.Location = new Point(239, 201);
            txtATR.Name = "txtATR";
            txtATR.Size = new Size(305, 22);
            txtATR.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(239, 119);
            label6.Name = "label6";
            label6.Size = new Size(206, 22);
            label6.TabIndex = 11;
            label6.Text = "Toneladas Por Alqueire";
            // 
            // txtToneladasPorAlqueire
            // 
            txtToneladasPorAlqueire.BorderStyle = BorderStyle.None;
            txtToneladasPorAlqueire.Location = new Point(239, 144);
            txtToneladasPorAlqueire.Name = "txtToneladasPorAlqueire";
            txtToneladasPorAlqueire.Size = new Size(305, 22);
            txtToneladasPorAlqueire.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(239, 62);
            label5.Name = "label5";
            label5.Size = new Size(90, 22);
            label5.TabIndex = 9;
            label5.Text = "Alqueires";
            // 
            // txtAlqueires
            // 
            txtAlqueires.BorderStyle = BorderStyle.None;
            txtAlqueires.Location = new Point(239, 87);
            txtAlqueires.Name = "txtAlqueires";
            txtAlqueires.Size = new Size(305, 22);
            txtAlqueires.TabIndex = 8;
            // 
            // btnRetornar
            // 
            btnRetornar.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnRetornar.Location = new Point(539, 404);
            btnRetornar.Name = "btnRetornar";
            btnRetornar.Size = new Size(261, 43);
            btnRetornar.TabIndex = 1;
            btnRetornar.Text = "Retornar";
            btnRetornar.UseVisualStyleBackColor = true;
            btnRetornar.Click += btnRetornar_Click;
            // 
            // FormDetalhesFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRetornar);
            Controls.Add(tabControlDetalhes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDetalhesFornecedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalhes Fornecedor";
            Load += FormDetalhesFornecedor_Load;
            tabControlDetalhes.ResumeLayout(false);
            tabPageHistorico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).EndInit();
            tabPageEntrega.ResumeLayout(false);
            tabPageEntrega.PerformLayout();
            tabPageArrendamento.ResumeLayout(false);
            tabPageArrendamento.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlDetalhes;
        private TabPage tabPageHistorico;
        private TabPage tabPageEntrega;
        private TabPage tabPageArrendamento;
        private DataGridView dgvHistorico;
        private Button btnSalvarEntrega;
        private Label label4;
        private TextBox txtATREntrega;
        private Label label3;
        private TextBox txtToneladasEntrega;
        private Label label2;
        private TextBox txtAnoEntrega;
        private Label label1;
        private TextBox txtMesEntrega;
        private Button btnSalvarArrendamento;
        private Label label7;
        private TextBox txtATR;
        private Label label6;
        private TextBox txtToneladasPorAlqueire;
        private Label label5;
        private TextBox txtAlqueires;
        private Button btnRetornar;
        private Button btnGerarArquivo;
    }
}