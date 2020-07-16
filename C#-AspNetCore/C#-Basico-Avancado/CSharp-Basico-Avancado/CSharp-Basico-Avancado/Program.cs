using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basico_Avancado
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double SumNumbers(List<double[]> setsOfNumbers, int indexOfSetToSum)
            {
                //trabalhando com valor null setsOfNumbers?[indexOfSetToSum]? e retorno NaN
                return setsOfNumbers?[indexOfSetToSum]?.Sum() ?? double.NaN;
            }

            var sum1 = SumNumbers(null, 0);
            Console.WriteLine(sum1);  // output: NaN


            //lista de array de double
            var numberSets = new List<double[]>
                    {
                        new[] { 1.0, 2.0, 3.0 },
                        new [] {2.0, 3.0 }
                    };

            var sum2 = SumNumbers(numberSets, 0);
            Console.WriteLine(sum2);  // output: 6

            var sum3 = SumNumbers(numberSets, 1);
            Console.WriteLine(sum3);  // output: NaN
            Console.ReadKey();

        }
    }
}
