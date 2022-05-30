using System;
using System.IO;

namespace _StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Stream Writer:

            - É uma stream capaz de escrever caracteres a partir de uma stream binária (ex: FileStream).
            - Suporte a dados no formato de texto.
            
                Instantiation:
            - Several constructors
            - File / FileInfo
                *CreateText(path)
                *AppendText(String)
            */

            string sourcePath = @"C:\temp\file1.txt";
            string targetPath = @"C:\temp\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
