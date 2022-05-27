using System;
using System.IO;

namespace File_FileInfo_IOException
{
    class Program
    {
        static void Main(string[] args)
        {
            //Caminho de origem do arquivo
            string sourcePath = @"C:\temp\file1.txt";
            //Caminho do arquivo de destino
            string targetPath = @"C:\temp\file2.txt";
                        
            //Usar bloco try para trabalhar com arquivo pois assim se pode capturar um erro com IOException
            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
