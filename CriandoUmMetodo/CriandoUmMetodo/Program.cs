using System;
using System.Globalization;

namespace CriandoUmMetodo
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            //Utilizando o método para retornar o valor da áreaX
            double areaX = x.Area();
            //Utilizando o método para retornar o valor da áreaY
            double areaY = y.Area();

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
