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
        int luck_max = 0;

        Luck luck = new Luck();
        MetodosAuxiliares metodosAuxiliares = new MetodosAuxiliares();
        BasicDAL basicDAL = new BasicDAL();
        
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
            luck.GeraNumeroSorte(num, luck_max);
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
            basicDAL.testaInsercao();
        }


        // testa database
        private void Botao_TestaConexao(object sender, EventArgs e)
        {
            basicDAL.TestaConexao();
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
         

            //retorna data time tratado
            var hashMetAux = metodosAuxiliares.DataTempoAgora();
            var tempo = metodosAuxiliares.DataTempoAgora();
            //Type type = GetType(type);
            Console.WriteLine(tempo);
            Console.WriteLine(hashMetAux);

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

        private void button6_Click(object sender, EventArgs e)
        {
            //metodosAuxiliares.DataTempoAgora();
            //basicDAL.TestaConexao();
        }
    }
}

