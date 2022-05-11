using System;
using System.Globalization;

namespace MembrosEstaticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Imprimindo a Circunferência 
            double circ = Calculadora.Circunferencia(raio);
            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));

            //Imprimindo o Volume
            double volume = Calculadora.Volume(raio);
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));

            //Valor de Pi
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
