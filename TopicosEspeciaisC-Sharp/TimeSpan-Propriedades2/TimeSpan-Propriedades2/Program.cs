using System;

namespace TimeSpan_Propriedades2
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(1, 30, 10); //1h 30m 10s
            TimeSpan t2 = new TimeSpan(0, 10, 5); //10m 5s

            //Adicionando(somando) t2 à t1
            TimeSpan sum = t1.Add(t2);

            //Subtraindo 
            TimeSpan dif = t1.Subtract(t2);

            //Multiplicando
            TimeSpan mult = t2.Multiply(2.0); //Multiplica por 2 (parametro recebe double)

            //Dividir
            TimeSpan div = t2.Divide(2.0); //Divide por 2 (parametro recebe double)

            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);
        }
    }
}
