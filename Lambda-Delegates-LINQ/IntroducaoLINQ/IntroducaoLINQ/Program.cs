using System;
using System.Linq;

namespace IntroducaoLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //specifying the data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            //define the query expression
            var result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            //execute the query
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
