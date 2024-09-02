using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;

namespace FaturamentoFornecedores
{
    public partial class FormDetalhesFornecedor : Form
    {

        private int fornecedorID;
        private string modalidade;

        public FormDetalhesFornecedor(int fornecedorID, string modalidade)
        {
            InitializeComponent();
            this.fornecedorID = fornecedorID;
            this.modalidade = modalidade;
            CarregarHistorico();
        }

        private void CarregarHistorico()
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            DataTable historico;

            if (modalidade == "Entrega")
            {
                historico = dbHelper.ObterHistoricoEntrega(fornecedorID);
                tabControlDetalhes.TabPages["tabPageArrendamento"].Enabled = false;
            }
            else
            {
                historico = dbHelper.ObterHistoricoArrendamento(fornecedorID);
                tabControlDetalhes.TabPages["tabPageEntrega"].Enabled = false;
            }

            dgvHistorico.DataSource = historico;
        }

        public FormDetalhesFornecedor()
        {
            InitializeComponent();
        }

        private void FormDetalhesFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvarEntrega_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtMesEntrega.Text) ||
                string.IsNullOrWhiteSpace(txtAnoEntrega.Text) ||
                string.IsNullOrWhiteSpace(txtToneladasEntrega.Text) ||
                string.IsNullOrWhiteSpace(txtATREntrega.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios para salvar a entrega.", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sai do método sem prosseguir com a inserção
            }
            // Obter dados do formulário
            int mes = int.Parse(txtMesEntrega.Text);
            int ano = int.Parse(txtAnoEntrega.Text);
            decimal toneladas = decimal.Parse(txtToneladasEntrega.Text);
            decimal atr = decimal.Parse(txtATREntrega.Text);

            // Calcular valores
            decimal valorTotal = toneladas * atr;
            decimal valorReceber = valorTotal - (valorTotal * 0.015M);

            // Inserir no banco de dados
            DatabaseHelper dbHelper = new DatabaseHelper();
            dbHelper.InserirEntrega(fornecedorID, mes, ano, toneladas, atr, valorTotal, valorReceber);

            // Atualizar histórico
            CarregarHistorico();
            tabControlDetalhes.SelectTab("tabPageHistorico");
        }

        private void btnSalvarArrendamento_Click(object sender, EventArgs e)
        {

            // Validações de entrada
            if (string.IsNullOrWhiteSpace(txtAlqueires.Text) ||
                string.IsNullOrWhiteSpace(txtToneladasPorAlqueire.Text) ||
                string.IsNullOrWhiteSpace(txtATR.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios para salvar o arrendamento.", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sai do método sem prosseguir com a inserção
            }
            // Obter dados do formulário
            decimal alqueires = decimal.Parse(txtAlqueires.Text);
            decimal toneladasPorAlqueire = decimal.Parse(txtToneladasPorAlqueire.Text);
            decimal atr = decimal.Parse(txtATR.Text);

            // Calcular valores
            decimal valorAno = alqueires * toneladasPorAlqueire;
            decimal valorMes = valorAno / 12;
            decimal totalReceber = valorMes * atr;

            // Inserir no banco de dados
            DatabaseHelper dbHelper = new DatabaseHelper();
            dbHelper.InserirArrendamento(fornecedorID, alqueires, toneladasPorAlqueire, valorAno, valorMes, atr, totalReceber);

            // Atualizar histórico
            CarregarHistorico();
            tabControlDetalhes.SelectTab("tabPageHistorico");
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual e retorna à tela principal
        }

        private void btnGerarArquivo_Click(object sender, EventArgs e)
        {
            // Verificar se há linhas para exportar
            if (dgvHistorico.Rows.Count == 0)
            {
                MessageBox.Show("Não há dados para exportar.", "Sem dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Configurar o diálogo para salvar arquivo
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Arquivo Excel (*.xlsx)|*.xlsx|Todos os arquivos (*.*)|*.*";
                saveFileDialog.Title = "Salvar Histórico";
                saveFileDialog.FileName = "historico_fornecedor.xlsx";
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Definir a propriedade LicenseContext do EPPlus
                    OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial; // Defina o contexto apropriado aqui

                    // Criar um novo arquivo Excel usando EPPlus
                    using (OfficeOpenXml.ExcelPackage excelPackage = new OfficeOpenXml.ExcelPackage())
                    {
                        // Adicionar uma planilha ao pacote Excel
                        OfficeOpenXml.ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Histórico");

                        // Escrever cabeçalho
                        for (int i = 0; i < dgvHistorico.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i + 1].Value = dgvHistorico.Columns[i].HeaderText;
                            worksheet.Cells[1, i + 1].Style.Font.Bold = true;
                            worksheet.Cells[1, i + 1].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                            worksheet.Cells[1, i + 1].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                        }

                        // Escrever dados
                        for (int i = 0; i < dgvHistorico.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvHistorico.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 2, j + 1].Value = dgvHistorico.Rows[i].Cells[j].Value;
                            }
                        }

                        // Ajustar o estilo da planilha
                        worksheet.Cells.AutoFitColumns();

                        // Salvar o arquivo Excel
                        System.IO.FileInfo excelFile = new System.IO.FileInfo(saveFileDialog.FileName);
                        excelPackage.SaveAs(excelFile);

                        MessageBox.Show("Arquivo Excel gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar arquivo Excel: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvHistorico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
