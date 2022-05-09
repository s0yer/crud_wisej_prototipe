using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;
using Wisej.Web;


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

        

        private void button1_Click(object sender, System.EventArgs e)
        {
            int numero_sorte = rd.Next(55, 5555);
            luck_max= Math.Max(numero_sorte, luck_max);

        MessageBox.Show($"O numero da sorte e {numero_sorte}" +  $"\nNumero de bilhetes retirados {num}" + $"\nSorte maxima foi {luck_max}");

            num++;
        }

        private void button2_Click(object sender, EventArgs e)
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
                MessageBox.Show($"Rode primeiro o numero da sorte.");

            }

            novaWindow nw = new novaWindow();
            nw.Show();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection())
                {
                    //pode passar o ip no server
                    //porta padrao 3306
                    cnn.ConnectionString = "server=localhost;database=randnum;uid=root;pwd=123456;port=3306";
                    cnn.Open();
                    MessageBox.Show($"Conexao com o mysql OK");
                }

            }
            //erro acontece a partir de aqui
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }

}

