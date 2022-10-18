using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
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

        //public MySqlConnection AbreConexao(ConnectionStringSettings connectionString)
        public MySqlConnection AbreConexao()
        {

            //this.conexao = new MySqlConnection("server=localhost;database=mydb;uid=root;password=123456;port=3306;");
            //public static byte[] strConexao = Convert.FromBase64String("c2VydmVyPWxvY2FsaG9zdDtkYXRhYmFzZT1teWRiO3VpZD1yb290O3Bhc3N3b3JkPTEyMzQ1Njtwb3J0PTMzMDY7");
            public static byte[] strConexao = Encoding.Default.GetBytes("c2VydmVyPWxvY2FsaG9zdDtkYXRhYmFzZT1teWRiO3VpZD1yb290O3Bhc3N3b3JkPTEyMzQ1Njtwb3J0PTMzMDY7");
            public string strDecode = Encoding.UTF8.GetString(strConexao);
            //this.conexao = new MySqlConnection(Encoding.UTF8.GetString(strConexao));
            this.conexao = new MySqlConnection(strDecode);

            //string connString = ConfigurationManager.ConnectionStrings[“database1”].ConnectionString;
            //this.conexao = new MySqlConnection("stringconnection?");
            

            this.conexao.Open();
            //MessageBox.Show("Conexao aberta...");
            //Console.WriteLine("Conexao aberta...");

            return this.conexao;
        }

    public bool EstadoConexao(MySqlConnection conexao)
    {
        if (conexao.State == System.Data.ConnectionState.Open)
        {
            return true;
        }
        else { return false; }

    }


    public void Dispose()
    {
        this.conexao.Close();
        this.conexao.Dispose();
    }

    internal void Adicionar(Luck lu)
    {
        try
        {
            //var conexao = AbreConexao();

            var insertCmd = AbreConexao().CreateCommand();
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


}

}