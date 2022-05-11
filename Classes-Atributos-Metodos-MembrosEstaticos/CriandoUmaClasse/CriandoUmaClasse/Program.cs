using System;
using System.Globalization;

namespace CriandoUmaClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Utilizando Classes para calcular a àrea de um triângulo

            //Declarando as variáveis triangulo
            Triangulo x, y;

            //Instanciando as variáveis, fazendo com que elas recebam os atributos de triângulo (A, B e C)
            x = new Triangulo();
            y = new Triangulo();

            //Utilizar o "." para atribuir valor à um atributo específico na classe
            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (x.A + x.B + x.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Área de X: " + areaX);
            Console.WriteLine("Área de X: " + areaY);

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}
