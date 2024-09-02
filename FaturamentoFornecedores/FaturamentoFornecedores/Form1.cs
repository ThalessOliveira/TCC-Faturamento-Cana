namespace FaturamentoFornecedores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            FormCadastrarFornecedor formCadastrar = new FormCadastrarFornecedor();
            formCadastrar.Show();
        }

        private void btnSelecionarFornecedor_Click(object sender, EventArgs e)
        {
            FormSelecionarFornecedor formSelecionar = new FormSelecionarFornecedor();
            formSelecionar.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
