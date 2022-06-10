namespace Delegates.Services
{
    internal class CalculationService
    {
        public static double Max(double x, double y) //maior entre eles
        {
            return (x > y) ? x : y; //condicao ternaria 
        }

        public static double Sum(double x, double y) //retorna a soma
        {
            return x + y;
        }

        public static double Square(double x) //retorna o numero ao quadrado
        {
            return x * x;
        }
    }
}
