using System;
using System.Globalization;

namespace EntradaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados com Split                        

            //Recorta as palavras separadas por espaço em branco e cria um vetor com as posições a partir de '0'
            string[] vet = Console.ReadLine().Split(' ');
            //Atribuindo os valores à variáveis string
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            //Entrada de dados Parte 2

            //Entrada de número inteiro
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine(n1);

            //Entrada de caractere
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine(ch);

            //Entrada de número double
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(n2.ToString("F2"), CultureInfo.InvariantCulture);

            //Leitura de dados com diferentes tipos de variáveis
            string[] s = Console.ReadLine().Split(' ');
            //Atribuindo as variáveis
            string nome = s[0];
            char sexo = char.Parse(s[1]);
            int idade = int.Parse(s[2]);
            double altura = double.Parse(s[3], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura);


            //Exercício de fixação

            //Entrada de dados

            //Nome
            Console.WriteLine("Entre com seu nome completo:");
            string nomeCompleto = Console.ReadLine();

            //Quartos na casa
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            //Preço produto
            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Ultimo nome, idade e altura (utilizando Split)
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] vet1 = Console.ReadLine().Split(' ');
            //Atribuindo os dados
            string s1 = vet1[0];
            int s2 = int.Parse(vet1[1]);
            double s3 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);

        }
    }
}
