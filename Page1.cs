using MySql.Data.MySqlClient;
using System;
using Wisej.Web;
using System.IO;
using System.Configuration;
using System.Data;
using MySqlCommand = MySql.Data.MySqlClient.MySqlCommand;
using Humanizer;

namespace crud_wisej_prototipe
{
    public partial class Page1 : Page
    {
        int num = 0;
        Random rd = new Random();
        int luck_max = 0;

        public Page1()
        {
            InitializeComponent();
        }

        // a ser implementado
        static void exe_luck_num()
        {
            MessageBox.Show("metodo roda luck num");
        }






        private void Botao_GeraNumeroSorte(object sender, EventArgs e)
        {
            int numero_sorte = rd.Next(55, 5555);
            luck_max = Math.Max(numero_sorte, luck_max);
            MessageBox.Show($"O numero da sorte e {numero_sorte}" + $"\nNumero de bilhetes retirados {num}" + $"\nSorte maxima foi {luck_max}");
            num++;
        }

        //botao numero da sorte
        private void Botao_TestaSorte(object sender, EventArgs e)
        {
            try
            {
                if (luck_max > 54)
                {
                    MessageBox.Show($"\n Parabens numero da sorte esta dentro dos parametros {luck_max}");
                }
            }
            catch
            {
                MessageBox.Show($"Rode primeiro o numero da sorte. :)");
            }
            novaWindow nw = new novaWindow();
            nw.Show();
        }

        // popula database
        private void Botao_PopulaTabela(object sender, EventArgs e)
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

                    DateTime dataInstante = DateTime.Now;
                    DateTime apenasData = DateTime.Today;

                    string.Format("select convert(dataInstante, '{0:s}'", DateTime.Now);

                    DateTime dataTratada = DateTimeExtensions.ToClientTime(dataInstante); // o slq nao consegue entender o formato desse jeito
                    MessageBox.Show("O tempo Voa: " + dataTratada + " | " + dataInstante + " | " + apenasData);

                    //String InsertCliente = ($"INSERT INTO lucknumber (numero, datetime) VALUES({crazy_number}, convert(dataTratada,'18-06-12 10:34:09 PM',5))");
                    String InsertCliente = ($"INSERT INTO lucknumber (numero, datetime) VALUES({crazy_number}, 'dataInstante')");

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


        // testa database
        private void Botao_TestaConexao(object sender, EventArgs e)
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

        //salva txt
        private void Botao_SalvaTxt(object sender, EventArgs e)
        {
            ExportaDados exportar = new ExportaDados();
            exportar.ExportaTxt();
        }

        // mostra dados em terminal
        private void Botao_MostraDBTerminal(object sender, EventArgs e)
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


                        //MessageBox.Show("Successfully login");
                        //dataGridView1.DataSource = numeros;
                        //label1.Text = numeros.ToString();
                    
 
        }

        private void Page1_Load(object sender, EventArgs e)
        {
            //MySqlConnection conn = new MySqlConnection("server=localhost;database=mydb;uid=root;password=123456;port=3306;");
            //MySqlDataAdapter mda = new MySqlDataAdapter("SHOW DATABASES;", conn);

            //conn.Open();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

