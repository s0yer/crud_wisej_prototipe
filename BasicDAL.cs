using MySql.Data.MySqlClient;
using System;
using Wisej.Web;

namespace crud_wisej_prototipe
{
    public class BasicDAL
    {

    public void testaInsercao()
        {
            try
            {
                string myConnectionString = "server=localhost;database=mydb;uid=root;password=123456;port=3306;";
                var conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                conn.Open();

                // conexao aberta -----------
                //gera objeto aleatorio
                Random rd = new Random();



                // loop que popula tabela com numeros aleatorios
                // insere 10 valores aleatorios
                int i = 0;
                while (i < 10)
                {

                    int crazy_number = rd.Next(55, 5555);



                    //String InsertCliente = ($"INSERT INTO lucknumber (numero, datetime) VALUES({crazy_number}, convert(dataTratada,'18-06-12 10:34:09 PM',5))");
                    //String InsertCliente = ($"INSERT INTO lucknumber (numero, datetime) VALUES({crazy_number}, 'dataInstante')");
                    String InsertCliente = ($"INSERT INTO lucknumber (numero) VALUES({crazy_number})");

                    MySqlCommand cmd = new MySqlCommand(InsertCliente, conn);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        Console.WriteLine($"\nDado Inserido: {crazy_number}");
                    }
                    else
                    {
                        MessageBox.Show("Erros - Dados nao Inseridos");
                    }
                    i++;
                }
                MessageBox.Show("Dados Inseridos");
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    public void AbreConexao() // precisa de retorno do conn?
        {
            {
                string myConnectionString = "server=localhost;database=mydb;uid=root;password=123456;port=3306;";

                try
                {
                    var conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                    conn.Open();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    public void TestaConexao()
        {
            {
                string myConnectionString = "server=localhost;database=mydb;uid=root;password=123456;port=3306;";

                try
                {
                    var conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                    conn.Open();
                    MessageBox.Show($"Conexao com sucesso");
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }

}