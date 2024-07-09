using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FaturamentoFornecedores
{
    public partial class FormSelecionarFornecedor : Form
    {
        public FormSelecionarFornecedor()
        {
            InitializeComponent();
        }

        private void FormSelecionarFornecedor_Load(object sender, EventArgs e)
        {
            CarregarFornecedores();
        }

        private void CarregarFornecedores()
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            DataTable fornecedores = dbHelper.ObterFornecedores();

            dgvFornecedores.DataSource = fornecedores;
            dgvFornecedores.Columns["FornecedorID"].Visible = false; // Ocultar a coluna FornecedorID
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (dgvFornecedores.SelectedRows.Count > 0)
            {
                int fornecedorID = Convert.ToInt32(dgvFornecedores.SelectedRows[0].Cells["FornecedorID"].Value);
                string modalidade = dgvFornecedores.SelectedRows[0].Cells["Modalidade"].Value.ToString();

                FormDetalhesFornecedor formDetalhes = new FormDetalhesFornecedor(fornecedorID, modalidade);
                formDetalhes.Show();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um fornecedor.");
            }
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual e retorna à tela principal
        }

        private void btnRetornar_Click_1(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual e retorna à tela principal
        }
    }
}

