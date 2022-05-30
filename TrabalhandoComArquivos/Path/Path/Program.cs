using System;
using System.IO;

namespace _Path
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Path (caminho):
            
            - Namespace System.IO
            - Realiza operações com strings que contém informações de arquivos ou pastas.
            */

            string path = @"c:\temp\myfolder\file1.txt";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path)); //nome da pasta
            Console.WriteLine("GetFileName: " + Path.GetFileName(path)); //nome do arquivo
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath()); //pasta temporária do sistema
        }
    }
}
