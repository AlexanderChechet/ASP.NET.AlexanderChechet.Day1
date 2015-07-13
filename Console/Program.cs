using System;
using System.Linq;
using Task1;
using Task2;

namespace ConsoleProject
{
    class Program
    {
        private static void Main(string[] args)
        {
            int number, power;
            double accuracy;
            Console.WriteLine("Enter number");
            int.TryParse(Console.ReadLine(), out number);
            Console.WriteLine("Enter power");
            int.TryParse(Console.ReadLine(), out power);
            Console.WriteLine("Enter accuracy");
            double.TryParse(Console.ReadLine(), out accuracy);
            Console.WriteLine("CustomMath.Pow = {0}", CustomMath.Pow(number, power, accuracy));
            Console.WriteLine("      Math.Pow = {0}", Math.Pow(number, (double)1/power));
            Console.ReadLine();

            int[][] array = {
                new []{10, 20, 30}, 
                new []{21, 32, 41},
                new []{25, 44, 11},
                new []{19, 21, 32},
                new []{21, 14, 47}
            };
            Sorter.Sort(array, SummaCondition, true);
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write("{0} ", array[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        private static int SummaCondition(int[] array)
        {
            return array.Sum();
        }
    }
}
