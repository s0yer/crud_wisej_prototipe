using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using Wisej.Web;

namespace crud_wisej_prototipe
{
    public class BasicDAL
    {

    private MySqlConnection conexao;               

    //Construtor que ja abre a conexao quando executa a aplicacao
    public BasicDAL()
        {
            //criar um metodo para ver se o bd existe
            try
            {
               // AbreConexao();
                //this.conexao = new mysqlconnection("server=localhost;database=mydb;uid=root;password=123456;port=3306;");
                //this.conexao.open();
                //messagebox.show("conexao aberta...");

                //estadoconexao(conexao);
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

        public MySqlConnection AbreConexao()
        {
            this.conexao = new MySqlConnection("server=localhost;database=mydb;uid=root;password=123456;port=3306;");
            this.conexao.Open();
            //MessageBox.Show("Conexao aberta...");
            Console.WriteLine("Conexao aberta...");

            return this.conexao;
        }

        public bool EstadoConexao(MySqlConnection conexao)
        {
            if(conexao.State == System.Data.ConnectionState.Open)
            {
                return true;
            }
            else { return false; }
            
        }


        public void Dispose()
        {
            this.conexao.Close();
        }

    internal void Adicionar(Luck lu)
        {
            try
            {
                var conexao = AbreConexao();

                var insertCmd = conexao.CreateCommand();
                insertCmd.CommandText = "INSERT INTO lucknumber (numero) VALUES (@numero)";

                var paramNumero = new MySqlParameter("numero", lu.numero);
                insertCmd.Parameters.Add(paramNumero);

                //conexao.Close();
                Dispose();
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

    internal void Atualizar(Luck lu)
        {
            try
            {
                var updateCmd = conexao.CreateCommand();
                updateCmd.CommandText = "UPDATE lucknumber SET numero = @numero WHERE Id = @id";

                var paraNumero = new MySqlParameter("numero", lu.numero);
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


    internal void Remover(Luck lu)
        {
            try
            {
                var deleteCmd = conexao.CreateCommand();
                deleteCmd.CommandText = "DELETE FROM lucknum WHERE Id = @id";

                var paraNumero = new MySqlParameter("id", lu.Id);
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



        // metodos antigos --------------------------


    //public void AbreConexao() // precisa de retorno do conn?
    //    {
    //        {
    //            string myConnectionString = "server=localhost;database=mydb;uid=root;password=123456;port=3306;";

    //            try
    //            {
    //                var conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
    //                conn.Open();
    //            }
    //            catch (MySql.Data.MySqlClient.MySqlException ex)
    //            {
    //                MessageBox.Show(ex.Message);
    //            }
    //        }
    //    }
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