using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString = "Server=localhost;Database=Gestao_Estoque;Trusted_Connection=True;";

        using (SqlConnection conexao = new SqlConnection(connectionString))
        {
            try
            {
                conexao.Open();
                Console.WriteLine("✅ Conexão bem-sucedida!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Erro: " + ex.Message);
            }
        }
    }
}

public void InserirProduto(string nome, string codigo, int quantidade, decimal preco, string fornecedor)
{
    string connectionString = "Server=localhost;Database=SistemaGestao;Trusted_Connection=True;";

    using (SqlConnection conexao = new SqlConnection(connectionString))
    {
        string sql = "INSERT INTO Produtos (Nome, Codigo, Quantidade, Preco, Fornecedor) VALUES (@Nome, @Codigo, @Quantidade, @Preco, @Fornecedor)";

        SqlCommand cmd = new SqlCommand(sql, conexao);
        cmd.Parameters.AddWithValue("@Nome", nome);
        cmd.Parameters.AddWithValue("@Codigo", codigo);
        cmd.Parameters.AddWithValue("@Quantidade", quantidade);
        cmd.Parameters.AddWithValue("@Preco", preco);
        cmd.Parameters.AddWithValue("@Fornecedor", fornecedor);

        conexao.Open();
        cmd.ExecuteNonQuery();
    }
}

public void ListarProdutos()
{
    string connectionString = "Server=localhost;Database=SistemaGestao;Trusted_Connection=True;";

    using (SqlConnection conexao = new SqlConnection(connectionString))
    {
        string sql = "SELECT * FROM Produtos";
        SqlCommand cmd = new SqlCommand(sql, conexao);

        conexao.Open();
        SqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"{reader["Id"]} - {reader["Nome"]} - {reader["Quantidade"]} unidades");
        }
    }
}