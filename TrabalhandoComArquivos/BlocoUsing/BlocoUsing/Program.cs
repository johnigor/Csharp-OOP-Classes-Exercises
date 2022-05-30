using System;
using System.IO;

namespace BlocoUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Using Block:

            - Sintaxe simplificada que garante que os objetos IDispoasble serão fechados.
            - Objetos IDisposable NÃO são gerenciados pelo clr. Eles precisam ser manualmente fechados.
                Exemplos: Font, FileStream, StreamReader, StreamWriter
            */

            string path = @"C:\temp\file1.txt";

            //Tudo deste bloco será executado e ao final dele finalizado
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
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

