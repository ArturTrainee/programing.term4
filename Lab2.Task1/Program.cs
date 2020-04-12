using System;
using System.Collections.Generic;
using static System.Console;

namespace Lab2.Task1
{
    static class Program
    {

        private static void Main(string[] args)
        {
            WriteLine("Enter one of three options in formats:");
            WriteLine("0 x\n1 x\n2 x");
            WriteLine("Options: \n0 -- sqrt(abs(x);\n1 -- x^3;\n2 -- x + 3,5];\nx - some integer\n");
            WriteLine("Enter any other symbol to exit.\n");

            IDictionary<string, Func<int, double>> calcMethods = new Dictionary<string, Func<int, double>>
            {
                { "0", CalculateSqrt },
                { "1", CalculateQube },
                { "2", AddThreeAndHalf }
            };

            while (true)
            {
                try
                {
                    var input = ReadLine().Split(' ');

                    calcMethods.TryGetValue(input[0], out Func<int, double> calculationMethod);

                    WriteLine(calculationMethod.Invoke(int.Parse(input[1])));
                }
                catch (Exception)
                {
                    WriteLine("Exception: Invalid option entered.");
                    ReadKey();
                    break;
                }
            }
        }

        private static double CalculateSqrt(int value) => Math.Sqrt(Math.Abs(value));

        private static double CalculateQube(int value) => Math.Pow(value, 3);

        private static double AddThreeAndHalf(int value) => value + 3.5;
    }
}
