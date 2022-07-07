using System;
using Wisej.Web;

namespace crud_wisej_prototipe
{
    public class MetodosAuxiliares
    {

        public DateTime DataTempoAgora()
        {

            DateTime dataInstante = DateTime.Now;
            DateTime apenasData = DateTime.Today;

            string.Format("select convert(dataInstante, '{0:s}'", DateTime.Now);

            DateTime dataTratada = DateTimeExtensions.ToClientTime(dataInstante); // o slq nao consegue entender o formato desse jeito
            MessageBox.Show("O tempo Voa: " + dataTratada + " | " + dataInstante + " | " + apenasData);

            return dataTratada;

        }
    }
}