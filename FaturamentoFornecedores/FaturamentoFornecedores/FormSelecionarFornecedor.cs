using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FaturamentoFornecedores
{
    public partial class FormSelecionarFornecedor : Form
    {
        private DataTable fornecedores;

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
            fornecedores = dbHelper.ObterFornecedores();

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

        private void cboFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarDados();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            FiltrarDados();
        }

        private void FiltrarDados()
        {
            if (fornecedores != null)
            {
                string filtro = txtPesquisa.Text.Trim().Replace("'", "''"); // Substitui apóstrofos para evitar erros de SQL

                // Filtra primeiro pelo ComboBox
                string filtroComboBox = string.Empty;
                if (cboFornecedor.SelectedItem != null)
                {
                    filtroComboBox = cboFornecedor.SelectedItem.ToString();
                }

                // Cria a expressão de filtro combinando o ComboBox e o TextBox
                string filtroExpressao = $"Modalidade LIKE '%{filtroComboBox}%' AND (Nome LIKE '%{filtro}%' OR Modalidade LIKE '%{filtro}%')";

                // Filtra as linhas de acordo com a expressão
                DataRow[] linhasFiltradas = fornecedores.Select(filtroExpressao);

                // Cria um novo DataTable para mostrar os resultados filtrados
                DataTable dtFiltrado = fornecedores.Clone();
                foreach (DataRow row in linhasFiltradas)
                {
                    dtFiltrado.ImportRow(row);
                }

                // Define o DataTable filtrado como a fonte de dados do DataGridView
                dgvFornecedores.DataSource = dtFiltrado;
            }
        }

        private void limparFiltros_Click(object sender, EventArgs e)
        {
            CarregarFornecedores();

            cboFornecedor.Text = string.Empty;
            txtPesquisa.Text = string.Empty;

            CarregarFornecedores();

            cboFornecedor.Text = string.Empty;
            txtPesquisa.Text = string.Empty;
        }
    }
}