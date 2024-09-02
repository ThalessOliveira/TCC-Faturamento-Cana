using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace FaturamentoFornecedores
{
    public class DatabaseHelper
    {
        private string connectionString;

        public DatabaseHelper()
        {
            // Acessar a string de conexão a partir do App.config
            connectionString = ConfigurationManager.ConnectionStrings["FaturamentoDB"].ConnectionString;
        }

        public void InserirFornecedor(string nome, string endereco, string bairro, string cidade, string cep, string telefone, string email, string cpf, string rg, string modalidade)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Fornecedores (Nome, Endereco, Bairro, Cidade, CEP, Telefone, Email, CPF, RG, Modalidade) " +
                               "VALUES (@Nome, @Endereco, @Bairro, @Cidade, @CEP, @Telefone, @Email, @CPF, @RG, @Modalidade)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", nome);
                command.Parameters.AddWithValue("@Endereco", endereco);
                command.Parameters.AddWithValue("@Bairro", bairro);
                command.Parameters.AddWithValue("@Cidade", cidade);
                command.Parameters.AddWithValue("@CEP", cep);
                command.Parameters.AddWithValue("@Telefone", telefone);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@CPF", cpf);
                command.Parameters.AddWithValue("@RG", rg);
                command.Parameters.AddWithValue("@Modalidade", modalidade);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable ObterFornecedores()
        {
            DataTable dtFornecedores = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT FornecedorID, Nome, Modalidade FROM Fornecedores";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dtFornecedores);
            }

            return dtFornecedores;
        }

        public DataTable ObterHistoricoEntrega(int fornecedorID)
        {
            DataTable dtHistorico = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Mes, Ano, Toneladas, ATR, ValorTotal, ValorReceberDesconto FROM HistoricoEntregas WHERE FornecedorID = @FornecedorID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@FornecedorID", fornecedorID);
                adapter.Fill(dtHistorico);
            }

            return dtHistorico;
        }

        public DataTable ObterHistoricoArrendamento(int fornecedorID)
        {
            DataTable dtHistorico = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Alqueires, ToneladasPorAlqueire, ValorAno, ValorPorMes, ATRMes, TotalReceber FROM HistoricoArrendamentos WHERE FornecedorID = @FornecedorID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@FornecedorID", fornecedorID);
                adapter.Fill(dtHistorico);
            }

            return dtHistorico;
        }

        public void InserirEntrega(int fornecedorID, int mes, int ano, decimal toneladas, decimal atr, decimal valorTotal, decimal valorReceber)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO HistoricoEntregas (FornecedorID, Mes, Ano, Toneladas, ATR, ValorTotal, ValorReceberDesconto) " +
                               "VALUES (@FornecedorID, @Mes, @Ano, @Toneladas, @ValorATR, @ValorTotal, @ValorReceber)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FornecedorID", fornecedorID);
                command.Parameters.AddWithValue("@Mes", mes);
                command.Parameters.AddWithValue("@Ano", ano);
                command.Parameters.AddWithValue("@Toneladas", toneladas);
                command.Parameters.AddWithValue("@ValorATR", atr);
                command.Parameters.AddWithValue("@ValorTotal", valorTotal);
                command.Parameters.AddWithValue("@ValorReceber", valorReceber);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void InserirArrendamento(int fornecedorID, decimal alqueires, decimal toneladasPorAlqueire, decimal valorAno, decimal valorMes, decimal atr, decimal totalReceber)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO HistoricoArrendamentos (FornecedorID, Alqueires, ToneladasPorAlqueire, ValorAno, ValorPorMes, ATRMes, TotalReceber) " +
                               "VALUES (@FornecedorID, @Alqueires, @ToneladasPorAlqueire, @ValorAno, @ValorPorMes, @ATRMes, @TotalReceber)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FornecedorID", fornecedorID);
                command.Parameters.AddWithValue("@Alqueires", alqueires);
                command.Parameters.AddWithValue("@ToneladasPorAlqueire", toneladasPorAlqueire);
                command.Parameters.AddWithValue("@ValorAno", valorAno);
                command.Parameters.AddWithValue("@ValorPorMes", valorMes);
                command.Parameters.AddWithValue("@ATRMes", atr);
                command.Parameters.AddWithValue("@TotalReceber", totalReceber);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable ExecutarConsulta(string query, params SqlParameter[] parametros)
        {
            DataTable dtResultados = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (parametros != null)
                        {
                            command.Parameters.AddRange(parametros);
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dtResultados);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Trate a exceção conforme necessário (log, mensagem para o usuário, etc.)
                Console.WriteLine("Erro ao executar consulta SQL: " + ex.Message);
            }

            return dtResultados;
        }
    }
}
