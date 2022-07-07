using System;
using Wisej.Web;

namespace crud_wisej_prototipe
{
    public class Luck
    {
        public int Id { get; internal set; }
        public int numero { get; internal set; }

        public override string ToString()
        {
            return $"Luck: {this.Id}, {this.numero}";
        }
        // construtor gera numero da sorte
        public void GeraNumeroSorte(int luck_max, int num)
        {
            Random rd = new Random();

            int numero_sorte = rd.Next(55, 5555);
            luck_max = Math.Max(numero_sorte, luck_max);
            MessageBox.Show($"O numero da sorte e {numero_sorte}" + $"\nNumero de bilhetes retirados {num}" + $"\nSorte maxima foi {luck_max}");
            num++;

            //return num;
        }
        public void TestaSorte(int luck_max)
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

    }

}