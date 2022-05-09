using System;
using Wisej.Web;

namespace crud_wisej_prototipe
{
    public partial class novaWindow : Form
    {
        public novaWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(((MonthCalendar)sender).SelectionStart.ToString(), "data selecionada e: ");
        }
    }
}
