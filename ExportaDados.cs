using System;
using System.IO;
using Wisej.Web;

namespace crud_wisej_prototipe
{
    public class ExportaDados
    {
        public void ExportaTxt()
        {
            // usa sistemIO
            string writeText = "Hello World!";  // Create a text string
            File.WriteAllText("filename.txt", writeText);  // Create a file and write the content of writeText to it

            string readText = File.ReadAllText("filename.txt");  // Read the contents of the file
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