using System;
using System.Collections.Generic;
using System.IO;
using Wisej.Web;

namespace crud_wisej_prototipe
{
    public class ExportaDados
    {
        //public void ExportaTxt(IList<Luck> lucks)
        public void ExportaTxt(string lucks)
        {
            // usa sistemIO
            string writeText = lucks.ToString();  // Create a text string
            File.WriteAllText("LogLucks.txt", writeText);  // Create a file and write the content of writeText to it

            string readText = File.ReadAllText("LogLucks.txt");  // Read the contents of the file
            //usa system
            Console.WriteLine(readText);  // Output the content

            MessageBox.Show($"Mensagem salva em TXT com sucesso. ");
        }


        //static void Cria_Log(string data)
        //{
        //    //verificar parte do codigo
        //    string writeText = data;  // Create a text string
        //    File.WriteAllText("log.txt", writeText);  // Create a file and write the content of writeText to it

        //    string readText = File.ReadAllText("log.txt");  // Read the contents of the file
        //    Console.WriteLine(readText);  // Output the content
        //}

    }

}