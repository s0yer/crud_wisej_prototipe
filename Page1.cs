using MySql.Data.MySqlClient;
using System;
using Wisej.Web;
using System.IO;
using System.Configuration;
using System.Data;
using MySqlCommand = MySql.Data.MySqlClient.MySqlCommand;
using Humanizer;
using System.Collections.Generic;

namespace crud_wisej_prototipe
{
    public partial class Page1 : Page
    {
        private const string V = "Teste de atribuicao";
        int num = 0;
        int luck_max = 0;
        string[] luckcar = { "Volvo", "BMW", "Ford", "Mazda", "Fiat" };
        string[] cores = { "blue", "red", "green", "yellow", "purple" };

        Luck luck = new Luck();
        MetodosAuxiliares metodosAuxiliares = new MetodosAuxiliares();
        LuckDTO luckDTO = new LuckDTO();

        public Page1()
        {

            InitializeComponent();
        }

        // botao auxiliar para teste
        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = luckDTO.RecuperaListaNumeros();
            listView1.DataSource = luckDTO.RecuperaListaNumeros();
            comboBox1.DataSource = luckcar;
            this.label1.Text = luckDTO.RetornaQtdNumeros().ToString();

        }

        private void Botao_GeraNumeroSorte(object sender, EventArgs e)
        {
            luck.GeraNumeroSorte(num, luck_max);
        }

        //botao numero da sorte
        private void Botao_TestaSorte(object sender, EventArgs e)
        {
            luck.TestaSorte(luck_max);
        }

        // popula database
        private void Botao_PopulaTabela(object sender, EventArgs e)
        {
            luckDTO.testaInsercao();
        }


        // testa database
        private void Botao_TestaConexao(object sender, EventArgs e)
        {
            luckDTO.TestaConexao();
        }

        //salva txtOrg
        private void Botao_SalvaTxt(object sender, EventArgs e)
        {
            ExportaDados exportar = new ExportaDados();

            var listaluck = luckDTO.RecuperaListaNumeros();
            exportar.ExportaTxtSys(luckDTO.RecuperaListaNumeros());
            //exportar.ExportaJson(luckDTO.RecuperaListaNumeros());
        }

        // mostra dados em terminal
        private void Botao_MostraDBTerminal(object sender, EventArgs e)
        {
            ShowItems_window nwTeste = new ShowItems_window();
            nwTeste.Show();

            // var hashMetAux = metodosAuxiliares.DataTempoAgora();
            //var tempo = metodosAuxiliares.DataTempoAgora();
            //Type type = GetType(type);

            //Console.WriteLine(tempo);
            //Console.WriteLine(luckDTO.RecuperaListaNumeros());
        }

        private void Page1_Load(object sender, EventArgs e)
        {

            dataGridView2.DataSource = luckDTO.RecuperaListaNumeros();
            listView1.DataSource = luckDTO.RecuperaListaNumeros();
            comboBox1.DataSource = luckcar;
            this.label1.Text = luckDTO.RetornaQtdNumeros().ToString();

            // popula treeview

            foreach (var luck in luckcar)
            {
                treeView1.Nodes.Add(new TreeNode(luck));
                treeView1.CheckBoxes = false;
            }
            //popula treeviewcombo

            //foreach (var luck in luckcar)
            //{
            //    treeViewComboBox1.Nodes.Add(new TreeNode(luck));
            //}            

            //foreach (var luck in luckcar)
            //{
            //    menuBar1.?(luck);
            //}






            //comboBox1.DataSource = basicDAL.RecuperaListaNumeros();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuBar1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Window nwTeste = new Window();
            nwTeste.Show();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeViewComboBox1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void menuBar2_Click(object sender, EventArgs e)
        {

        }
    }
}

