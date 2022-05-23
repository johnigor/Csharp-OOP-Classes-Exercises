using System;

namespace DateTimeKind1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             DateTimeKind: 
            Tipo enumerado especial que define três valores possíveis para a localidade da data:
            - Local [fuso horário do sistema. Exemplo: São Paulo = GMT - 3]
            - Utc [fuso horário GMT (Greenwich mean time)]
            - Unspecified

            Boa prática: 
            - Armazenar em formato UTC (texto: BD/Json/XML)
            - Instanciar e mostrar em formato Local

            Para converter um DateTime para Local ou Uc, você deve usar:
            - myDate.ToLocalTime()
            - myDate.ToUniversalTime()
             */

            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

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
            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3 Kind: " + d3.Kind);
            Console.WriteLine("d3 to local: " + d3.ToLocalTime());
            Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime());
            Console.WriteLine();

        }
    }
}
