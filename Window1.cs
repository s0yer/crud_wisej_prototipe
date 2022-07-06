using System;
using Wisej.Web;

namespace crud_wisej_prototipe
{
    public partial class ShowItems_window : Wisej.Web.Form
    {
        public ShowItems_window()
        {
            InitializeComponent();
        }

        private void ShowItems_window_Load(object sender, EventArgs e)
        {
            LuckDTO dto = new LuckDTO();
            listBox1.DataSource = dto.RecuperaListaNumeros();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
