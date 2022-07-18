using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using Wisej.Web;
using Wisej.Web.Ext.ChartJS;

namespace crud_wisej_prototipe
{
    public class LuckDTO
    {
        BasicDAL dal = new BasicDAL();

        public int RetornaQtdNumeros()
        {
            int total = 0;
            var selectCmd = dal.AbreConexao().CreateCommand();
            selectCmd.CommandText = "SELECT COUNT(numero) FROM lucknumber";

            //var resultado = selectCmd.ExecuteNonQuery();
            var resultado = selectCmd.ExecuteScalar();
            total = Convert.ToInt32(resultado);

            return total;
        }        
        
        public System.Data.DataSet RetornaDatasetWiseJ()
        {
            BasicDAL basicDAL = new BasicDAL();

            // comandos recuperam uma coluna apenas
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.TableMappings.Add("Table", "lucknum");


            MySqlCommand command = new MySqlCommand(
           "SELECT SupplierID, CompanyName FROM dbo.Suppliers;",
           basicDAL.AbreConexao());
            command.CommandType = CommandType.Text;

            adapter.SelectCommand = command;

            System.Data.DataSet ds = new System.Data.DataSet("lucknum");
            adapter.Fill(ds);

            return ds;
        }        
        
        //public DataSet RetornaDataset()
        //{
        //    BasicDAL basicDAL = new BasicDAL();

        //    // comandos recuperam uma coluna apenas
        //    MySqlDataAdapter adapter = new MySqlDataAdapter();
        //    adapter.TableMappings.Add("Table", "lucknum");


        //    MySqlCommand command = new MySqlCommand(
        //   "SELECT SupplierID, CompanyName FROM dbo.Suppliers;",
        //   basicDAL.AbreConexao());
        //    command.CommandType = CommandType.Text;

        //    adapter.SelectCommand = command;

        //    DataSet ds = new DataSet("lucknum");
        //    adapter.Fill(ds);

        //    return ds;
        //}



        public void InsercaoRandom()
        {
            try
            {
  
                //gera objeto aleatorio
                Random rd = new Random();
                Luck luck = new Luck();
                // loop que popula tabela com numeros aleatorios
                // insere 10 valores aleatorios
                int i = 0;
                while (i < 10)
                {

                    int crazy_number = rd.Next(55, 5555);
                    luck.numero = crazy_number;
                    dal.Adicionar(luck);                          
                    Console.WriteLine($"\nDado Inserido: {crazy_number}");                                    
                    
                    i++;

                }
                MessageBox.Show("Dados Inseridos");
                
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Erros - Dados nao Inseridos");
                MessageBox.Show(ex.Message);
            }
            //conexao.Close();
            
        }
                
        
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

        // necessita da biblioteca using System.Collections.Generic;
        internal IList<Luck> RecuperaListaNumeros()
        {
            var lista = new List<Luck>();
            var selectCmd = dal.AbreConexao().CreateCommand();
            selectCmd.CommandText = "SELECT * FROM lucknumber";

            var resultado = selectCmd.ExecuteReader();
            while (resultado.Read())
            {
                Luck lu = new Luck();
                lu.Id = Convert.ToInt32(resultado["Id"]);
                lu.numero = Convert.ToInt32(resultado["numero"]);

                //adiciona na lista um novo produto lido a cada loop
                lista.Add(lu);
            }
            resultado.Close();

            return lista;
        }

        public string ConversorLista(IList<Luck> listaluck)
        {
            string dados = string.Join(" | ", listaluck);

            return dados;
        }

        public void TestaConexao()
        {
            {
                string myConnectionString = "server=localhost;database=mydb;uid=root;password=123456;port=3306;";

                try
                {
                    var conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                    conn.Open();
                    if (dal.EstadoConexao(conn) == true)
                    {
                        MessageBox.Show($"Conexao com sucesso");

                    }
                    else
                    {
                        MessageBox.Show($"Nao esta conectado");

                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

