using System;
using System.Globalization;

namespace DateTime1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Representa um instante (data, ou data e horário)
            //É um tipo valor (struct)

            /* Um objeto DateTime internamente armazena: 
             O número de "ticks" (100 nanosegundos) desde a meia noite do dia 1 de janeiro do ano 1 da era comum. 
            
             Construtores: 
            DateTime(ano, mes, dia)
            DateTime(ano, mes, dia, hora, minuto, segundo) [opcional:kind]
            DateTime(ano, mes, dia, hora, minuto, segundo, milissegundo) [opcional:kind]

             Builders: Operações ou propriedades que vão instanciar para você um DateTime
            DateTime.Now
            DateTime.UtcNow
            DateTime.Today
            DateTime.Parse(string)
            DateTime.ParseExact(string, string)
            */


            //Mostra a data e horario de agora (o momento em que você está)
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            //Imprime a quantidade de ticks que já passaram desde o dia 1 de janeiro 00:00 da era atual, até o dia de hoje
            Console.WriteLine(d1.Ticks);

            DateTime d2 = new DateTime(2018, 11, 25); //Construtor com ano, mes e dia
            Console.WriteLine(d2);

            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3); //ano, mes, dia, hora, minuto e segundo
            Console.WriteLine(d3);

            DateTime d4 = new DateTime(2018, 11, 25, 20, 45, 3, 500); //ano, mes, dia, hora, minuto, segundo e milissegundo
            Console.WriteLine(d4);

            DateTime d5 = DateTime.Today; //Data de hoje porém com o horário zerado
            Console.WriteLine(d5);

            DateTime d6 = DateTime.UtcNow; //Horario de agora, porem no horario universal UTC
            Console.WriteLine(d6);

            //Utilizando o Parse para converter uma data de string para date time

            DateTime d7 = DateTime.Parse("2000-08-15"); //Ano, mes e dia (formato utilizado por alguns bancos de dados)
            Console.WriteLine(d7);
            DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
            Console.WriteLine(d8);

            DateTime d9 = DateTime.Parse("15/08/2000"); //Formato brasileiro
            Console.WriteLine(d9);
            DateTime d10 = DateTime.Parse("15/08/2000 13:05:58");
            Console.WriteLine(d10);

            //Parse Exact - Para voce determinar o formato da sua data

            DateTime d11 = DateTime.ParseExact("2000-08-15","yyyy-MM-dd", CultureInfo.InvariantCulture); //Mascara de formatacao
            Console.WriteLine(d11);

            DateTime d12 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d12);


        }
    }
}
