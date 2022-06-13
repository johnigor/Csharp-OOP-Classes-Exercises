using MulticastDelegates.Services;

namespace MulticastDelegates
{
    internal class Program
    {
        delegate void BinaryNumericOperation(double n1, double n2);
        static void Main(string[] args)
        {
            /*
            Multicast Delegates:
            - Delegates que guardam a referencia para mais de um metodo
            - Para adicionar uma referencia, pode-se usar o operador +=
            - A chamada Invoke (ou sintaxe reduzida) executa todos os metodos na ordem em que foram adicionados
            - Seu uso faz sentido para metodos void
            */

            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.ShowSum; //soma
            op += CalculationService.ShowMax; //máximo

            op.Invoke(a, b);

            //Também pode usar dessa forma:
            op(a, b);
        }
    }
}
