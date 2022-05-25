using System;

namespace Estrutura_try_catch
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            //"e" é um apelido dado à exceção
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error! " + e.Message); //imprime a mensagem de erro
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error! " + e.Message);
            }

        }
    }
}
