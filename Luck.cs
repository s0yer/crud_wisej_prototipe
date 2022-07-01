using System;
using Wisej.Web;

namespace crud_wisej_prototipe
{
    public class Luck
    {
        public void GeraNumeroSorte(int luck_max, int num)
        {
            Random rd = new Random();

            int numero_sorte = rd.Next(55, 5555);
            luck_max = Math.Max(numero_sorte, luck_max);
            MessageBox.Show($"O numero da sorte e {numero_sorte}" + $"\nNumero de bilhetes retirados {num}" + $"\nSorte maxima foi {luck_max}");
            num++;

            //return num;
        }
    }

}