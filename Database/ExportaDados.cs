//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Wisej.Web;


namespace crud_wisej_prototipe
{
    public class ExportaDados
    {


        public void ExportaTxtSys(IList<Luck> lista)
        {
            //string CaminhoNomeArquivo = @"C:/Users/servidor/Desktop/arquivo.txt";
            string CaminhoNomeArquivo = @"./LogLucks.txt";
            System.IO.TextWriter escrita = System.IO.File.AppendText(CaminhoNomeArquivo);

            escrita.Write("START LOG +++++++++++++++++\n");

            escrita.Write("> ");
            MetodosAuxiliares ma = new MetodosAuxiliares();
            escrita.Write(ma.DataTempoAgora());
            escrita.Write("\n-----------------------\n");

            foreach (var item in lista)
            {
                escrita.Write(item.Id + " | " + item.numero);
                escrita.Write(Environment.NewLine);
            }

            escrita.Write("END LOG ----------------\n");

            escrita.Close();

            MessageBox.Show($"Mensagem salva em TXT com sucesso. ");
        }
        //public void ExportaJson(IList<Luck> dados)
        //{
        //    var LogJson = "LogJson.json";

        //    string output = string.Join(Environment.NewLine, dados);
        //    //foreach (var item in dados)
        //    //{
        //    //    string jsonString = JsonSerializer.Serialize(item.Id + " | " + item.numero);      
        //    //}

        //    string jsonString = JsonSerializer.Serialize(output);
        //    File.WriteAllText(LogJson, jsonString);

        //    Console.WriteLine(File.ReadAllText(LogJson));
        //    MessageBox.Show($"Mensagem salva em JSON com sucesso. ");

        //}

        // --------------------old

        //public void ExportaTxt(IList<Luck> lucks)
        //public void ExportaTxt(string lucks)
        //{
        //    // usa sistemIO
        //    string writeText = lucks.ToString();  // Create a text string
        //    File.WriteAllText("LogLucks.txt", writeText);  // Create a file and write the content of writeText to it


        //    //-------------print
        //    string readText = File.ReadAllText("LogLucks.txt");  // Read the contents of the file
        //    //usa system
        //    Console.WriteLine(readText);  // Output the content

        //    MessageBox.Show($"Mensagem salva em TXT com sucesso. ");
        //}

    }

}