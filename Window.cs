using MySql.Data.MySqlClient;
using System;
//using System.Data;
using System.Drawing;
using Wisej.Web;
using Wisej.Web.Ext.ChartJS;

namespace crud_wisej_prototipe
{
    public partial class Window : Wisej.Web.Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void Window_Load(object sender, EventArgs e)
        {
            LuckDTO luckDTO = new LuckDTO();
            

            //chartJS1.DataSets.Add(luckDTO.RetornaDataset());
            // Randomize2();
        }

        private void chartJS1_ChartClick(object sender, ChartClickEventArgs e)
        {

        }

        private void Randomize()
        {
            foreach (Wisej.Web.Ext.ChartJS.ChartJS chart in this.chartJS1.Controls)
            {
                if (chart.DataSets.Count == 0)
                    chart.DataSets.Add("Data Set");

                CreateRandomData(chart.DataSets[0], 12, 100);
                //chart.UpdateData(this.trackBar.Value);
            }
        }

        private void Randomize2()
        {
            foreach (Wisej.Web.Ext.ChartJS.ChartJS chart in this.chartJS1.Controls)
            {
                if (chart.DataSets.Count == 0)
                    chart.DataSets.Add("Data Set");

                CreateRandomData(chart.DataSets[0], 12, 100);
            }
        }
        private void CreateRandomData(DataSet dataSet, int count, int maxValue)
        {
            var data = new object[count];
            Random random = new Random();
            for (int i = 0; i < count; i++)
                data[i] = random.Next(maxValue);

            dataSet.Data = data;

            var barDataSet = (BarDataSet)dataSet;

           //CreateColors(dataSet);
        }
    }

}
