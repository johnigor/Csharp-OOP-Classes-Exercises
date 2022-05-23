using System;

namespace Padrao_ISO8601
{
    class Program
    {
        static void Main(string[] args)
        {
            //Padrão ISO 8601
            //Formato: yyyy-MM-ddTHH:mm:ssZ
            //Z indica que a data/hora está em Utc

            DateTime d1 = DateTime.Parse("2000-08-05 13:05:58");
            DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z"); //Padrao ISO 8601

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ")); //cuidado!
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ")); //Primeiro garantir que ela esteja no formato universal para depois fazer o ToString
        }
    }
}
