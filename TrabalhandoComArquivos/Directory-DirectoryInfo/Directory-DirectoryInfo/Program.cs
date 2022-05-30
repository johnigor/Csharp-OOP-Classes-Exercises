using System;
using System.IO;
using System.Collections.Generic;

namespace Directory_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Directory, DirectoryInfo:

            - Namespace System.IO
            - Operações com pastas (create, enumerate, get files, etc.)
            
            - Directory:
                * static members (simple, but performs security check for each operation)
            - DirectoryInfo:
                * instance members
            */

            string path = @"C:\temp\myfolder";

            try
            {
                //Teste para listar todas as subpastas a partir da pasta "myfolder"
                //Para resumir a declaração "IEnumerable<string>", pode-se usar a palavara "var"
                // var folders = ...
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                //Listar todos os arquivos a partir de uma pasta
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                //Criar uma pasta
                Directory.CreateDirectory(path + "\\newfolder"); //Por ser string comum, deve-se usar duas barras ou então utilizar @"\
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
