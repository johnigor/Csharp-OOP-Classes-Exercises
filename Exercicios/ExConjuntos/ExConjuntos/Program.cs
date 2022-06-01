using System;
using System.IO;
using ExConjuntos.Entities;
using System.Collections.Generic;

namespace ExConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Problema exemplo: 
            Um site de internet registra um log de acessos dos usuários. Um registro de log consiste no nome de usuário
            e o instante em que o usuário acessou o site no padrão ISO 8601, separados por espaço, conforme exemplo.
            Fazer um programa que leia o log de acessos a partir de um arquivo, e daí informe quantos usuários distintos
            acessaram o site.
            */

            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using StreamReader sr = File.OpenText(path);
                while (!sr.EndOfStream) //enquanto sr nao estiver acabado, ler as linhas line
                {
                    string[] line = sr.ReadLine().Split(' '); //inserindo os dados e instaciando como vetor
                    string name = line[0]; //instanciando nas variáveis pela posicao do vetor
                    DateTime instant = DateTime.Parse(line[1]);
                    set.Add(new LogRecord(name, instant)); //sintaxe { Username = name, Instant = instant }; no caso de nao ter feito construtor
                }
                Console.WriteLine("Total users: " + set.Count);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
