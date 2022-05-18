using System;

namespace TimeSpan1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Representa uma duração
            //Tipo valor (struct)

            /* Um objeto TimeSpan internamente armazena uma duração na forma de ticks (100 nanosegundos)*/

            TimeSpan t1 = new TimeSpan(0, 1, 30); //construtor de 3 argumentos (hora, minuto, segundo)
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);

            TimeSpan t2 = new TimeSpan(); //Construtor padrão, vazio. Cria um TimeSpan com a duração 0
            Console.WriteLine(t2);
            
            TimeSpan t3 = new TimeSpan(900000000L); //Construtor informando a quantidade de ticks (o "L" no final significa LONG)
            Console.WriteLine(t3);

            TimeSpan t4 = new TimeSpan(2, 11, 21); //Horas minutos segundos
            Console.WriteLine(t4);

            TimeSpan t5 = new TimeSpan(1, 2, 11, 21); //Dia, hora, minuto, segundo
            Console.WriteLine(t5);

            TimeSpan t6 = new TimeSpan(1, 2, 11, 21, 321); //Dia, hora, minuto, segundo, milisegundos

            //Metodos From
            //Cria um TimeSpan equivalente a 1.5 dias
            TimeSpan t7 = TimeSpan.FromDays(1.5); 
            Console.WriteLine(t7);

            //TimeSpan de uma hora e meia
            TimeSpan t8 = TimeSpan.FromHours(1.5);
            Console.WriteLine(t8);

            //TimeSpan de um minuto e meio
            TimeSpan t9 = TimeSpan.FromMinutes(1.5);
            Console.WriteLine(t9);

            //TimeSpan de um segundo e meio
            TimeSpan t10 = TimeSpan.FromSeconds(1.5);
            Console.WriteLine(t10);

            //TimeSpan de um e meio milisegundos
            TimeSpan t11 = TimeSpan.FromMilliseconds(1.5);
            Console.WriteLine(t11);

            //TimeSpan de ticks
            TimeSpan t12 = TimeSpan.FromMinutes(900000000L);
            Console.WriteLine(t12);
        }
    }
}
