using System;
using System.Windows.Forms;

// Adicione esta linha se necessário
using FaturamentoFornecedores;

namespace FaturamentoFornecedores
{
    public partial class FormCadastrarFornecedor : Form
    {
        public FormCadastrarFornecedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual e retorna à tela principal
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            // Validações de entrada
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtEndereco.Text) ||
                string.IsNullOrWhiteSpace(txtBairro.Text) ||
                string.IsNullOrWhiteSpace(txtCidade.Text) ||
                string.IsNullOrWhiteSpace(txtCEP.Text) ||
                string.IsNullOrWhiteSpace(txtTelefone.Text) ||
                string.IsNullOrWhiteSpace(txtCPF.Text) ||
                string.IsNullOrWhiteSpace(txtRG.Text) ||
                cboModalidade.SelectedItem == null)
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sai do método sem prosseguir com a inserção
            }
            // Validações de entrada podem ser adicionadas aqui

            // Obter dados do formulário
            string nome = txtNome.Text;
            string endereco = txtEndereco.Text;
            string bairro = txtBairro.Text;
            string cidade = txtCidade.Text;
            string cep = txtCEP.Text;
            string telefone = txtTelefone.Text;
            string email = txtEmail.Text;
            string cpf = txtCPF.Text;
            string rg = txtRG.Text;
            string modalidade = cboModalidade.SelectedItem.ToString();

            // Inserir dados no banco de dados
            DatabaseHelper dbHelper = new DatabaseHelper();
            dbHelper.InserirFornecedor(nome, endereco, bairro, cidade, cep, telefone, email, cpf, rg, modalidade);

            MessageBox.Show("Fornecedor cadastrado com sucesso!");

            // Limpar campos após salvar
            txtNome.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtCEP.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtCPF.Clear();
            txtRG.Clear();
            cboModalidade.SelectedIndex = -1;
        }
    }
}
