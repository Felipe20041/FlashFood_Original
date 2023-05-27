using Microsoft.Data.SqlClient;

namespace FlashFood_Original
{
    public class Startup
    {
        private string connectionString = "Server=LAPTOP-F11OFJ3N\\KAUA;Database=BD_FlashFood;";

        public void ConectarAoBanco()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Conexão estabelecida com sucesso!");

                    // Faça operações no banco de dados aqui

                    connection.Close();
                    Console.WriteLine("Conexão encerrada com sucesso!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao conectar ao banco de dados: " + ex.Message);
            }
        }
    }
}
