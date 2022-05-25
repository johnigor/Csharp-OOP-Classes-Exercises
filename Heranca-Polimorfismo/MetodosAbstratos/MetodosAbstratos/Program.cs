using System;
using System.Globalization;
using System.Collections.Generic;
using MetodosAbstratos.Entities;
using MetodosAbstratos.Entities.Enums;

namespace MetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Métodos abstratos
            
            - São métodos que não possuem implementação
            - Métodos precisam ser abstratos quando a classe é genérica demais para conter sua implementação
            - Se uma classe possuir pelo menos um método abstrato, então esta classe também é abstrata.
            
            Notação UML: Itálico
            
            Exercício resolvido: Fazer um programa para ler os dados de N figuras (N fornecido pelo usuário),
            e depois mostrar as áreas destas figuras na mesma ordem em que foram digitadas
             */

            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int shapes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= shapes; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");
            foreach(Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
