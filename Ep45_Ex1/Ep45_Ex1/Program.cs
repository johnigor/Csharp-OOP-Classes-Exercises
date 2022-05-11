using System;
using System.Globalization;

namespace Ep45_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre a largura e a altura do retângulo");

            Console.Write("Largura: ");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Altura: ");
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Área = " + retangulo.Area().ToString("F2"));
            Console.WriteLine("Perímetro = " + retangulo.Perimetro().ToString("F2"));
            Console.WriteLine("Diagonal = " + retangulo.Diagonal().ToString("F2"));
        }
    }
}
