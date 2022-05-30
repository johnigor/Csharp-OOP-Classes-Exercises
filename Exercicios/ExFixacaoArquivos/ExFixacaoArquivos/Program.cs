using System;
using System.IO;
using System.Globalization;
using ExFixacaoArquivos.Entities;

namespace ExFixacaoArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            (Aula 201)
            
            Fazer um programa para ler o caminho de um arquivo .csv contendo os dados de itens vendidos.
            Cada item possui um nome, preço unitário e quantidade, separados por vírgula. Você deve gerar
            um novo arquivo chamado "summary.csv", localizado em uma subpasta chamada "out" a partir da
            pasta original do arquivo de origem, contendo apenas o nome e o valor total para aquele item
            (preço unitário multiplicado pela quantidade), conforme exemplo.
            */

            Console.Write("Entre com o caminho do arquivo de origem: ");
            string sourceFilePath = Console.ReadLine(); //usuário insere os dados do arquivo

            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath); //instanciação dos arquivos

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath); //get no caminho da pasta de origem
                string targetFolderPath = sourceFolderPath + @"\out"; //adicionando destino da subpasta concatenando com os dados da pasta de origem
                string targetFilePath = targetFolderPath + @"\summary.csv"; //definindo caminho do arquivo para a subpasta out

                Directory.CreateDirectory(targetFolderPath); //cria todos os diretórios e subdiretórios no caminho especificado

                using (StreamWriter sw = File.AppendText(targetFilePath)) //adiciona texto ao file destinado
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(','); //Instanciando em um vetor (fields/campos) sem as vírgulas
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        //instanciando os dados do produto
                        Product prod = new Product(name, price, quantity);

                        //imprimindo os dados no arquivo
                        sw.WriteLine(prod.Nome + ", " + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
