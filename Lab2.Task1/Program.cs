using System;
using System.Collections.Generic;

namespace Lab2.Task1
{
    public static class Program
    {
        private static double AddThreeAndHalf(int value)
        {
            return value + 3.5;
        }

        private static double CalculateQube(int value)
        {
            return Math.Pow(value, 3);
        }

        private static double CalculateSqrt(int value)
        {
            return Math.Sqrt(Math.Abs(value));
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Enter one of three options in formats:");
            Console.WriteLine("0 x\n1 x\n2 x");
            Console.WriteLine("Options: \n0 -- sqrt(abs(x);\n1 -- x^3;\n2 -- x + 3,5];\nx - some integer\n");
            Console.WriteLine("Enter any other symbol to exit.\n");

            IDictionary<string, Func<int, double>> calcMethods = new Dictionary<string, Func<int, double>>();
            calcMethods.Add("0", CalculateSqrt);
            calcMethods.Add("1", CalculateQube);
            calcMethods.Add("2", AddThreeAndHalf);

            while (true)
            {
                try
                {
                    var input = Console.ReadLine().Split(' ');

                    calcMethods.TryGetValue(input[0], out Func<int, double> calculationMethod);

                    Console.WriteLine(calculationMethod.Invoke(int.Parse(input[1])));
                }
                catch (Exception)
                {
                    Console.WriteLine("Exception: Invalid option entered.");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}