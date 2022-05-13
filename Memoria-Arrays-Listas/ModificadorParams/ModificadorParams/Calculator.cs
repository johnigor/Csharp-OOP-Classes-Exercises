namespace ModificadorParams
{
    internal class Calculator
    {
        //Pode utilizar um vetor dentro do parametro, no caso não saber exatamente quantos parâmetros irão ser atribuidos 
        public static int Sum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
