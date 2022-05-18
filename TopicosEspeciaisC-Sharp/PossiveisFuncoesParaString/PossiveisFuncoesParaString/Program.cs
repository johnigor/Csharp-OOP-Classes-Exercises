using System;

namespace PossiveisFuncoesParaString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Funções interessantes para string:
            Formatar: ToLower(), ToUpper(), Trim()
            Buscar: IndexOf, LastIndexOf
            Recortar: Substring(inicio), Substring(inicio, tamanho)
            Substituir: Replace(char, char), Replace(string, string)
            String.IsNullOrEmpty(str), String.IsNullOrWhiteSpace(str)
            str.Split(' ')
            Conversão para número: int x = int.Parse(str), int x = Convert.ToInt32(str)
            Conversão de número: str = x.ToString(), str = x.ToString("C"), str = x.ToString("C3"), str = x.ToString("F2")
            */

            string original = "abcde FGHIJ ABC abc DEFG   ";

            //Convertendo todos para maiusculo
            string s1 = original.ToUpper();
            //Convertendo todos para minusculo
            string s2 = original.ToLower();
            //Apaga os espaços em branco, antes e depois da string
            string s3 = original.Trim();
            //Descobrir a primeira ocorrencia
            int n1 = original.IndexOf("bc");
            //Ultima ocorrencia
            int n2 = original.LastIndexOf("bc");
            //Recortando a string a partir de certo ponto
            string s4 = original.Substring(3);
            //Recorta a partir de um certo ponto, porém apenas a quantidade de caracteres informados (5 como no exemplo)
            string s5 = original.Substring(3, 5);
            //Troca todas as ocorrencias de um caractere por outro, como no exemplo, troca 'a' por 'x'
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");

            //Testar se o usuario deixou algum campo em branco
            bool b1 = string.IsNullOrEmpty(original);
            //Testa se a variavel é nula ou entao está apenas com espaços em branco
            bool b2 = string.IsNullOrWhiteSpace(original);

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf(bc): " + n1);
            Console.WriteLine("LastIndexOf(bc): " + n2);
            Console.WriteLine("Substring(3): " + s4);
            Console.WriteLine("Substring(3, 5): " + s5);
            Console.WriteLine("Replace('a','x'): " + s6);
            Console.WriteLine("Replace('abc','xy'): " + s7);
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
        }
    }
}
