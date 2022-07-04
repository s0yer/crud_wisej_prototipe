using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using Wisej.Web;

namespace crud_wisej_prototipe
{
    public class LuckDTO
    {
        public void RetornaLista()
        {
            try{
                //var lista = new List<Luck>();

                var repo = new BasicDAL();
                String lista = repo.RecuperaListaNumeros().ToString();
                Console.WriteLine(lista);
            }
            catch (MySqlException e)
            {
                throw new SystemException(e.Message, e);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
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

        public void ConversorLista()
        {
            List<string> listaDAL = new List<string>();
            var resultado = String.Join(", ", listaDAL.ToArray());
            //var resultado = String.Join(", ", listaDAL.ToArray());

            //MessageBox.Show(resultado); // nao aparece nada
            Console.WriteLine(resultado);
        }
    }
}

