using System;

namespace Lab1

{

    static class Program

    {

        public static double Task2(int n, double eps)

        {

            double sum = 0;

            double term = double.MaxValue; // initial value to enter the loop

            for (int i = 1; Math.Abs(term) > eps; i++)

            {

                term = Math.Pow(-1, i) * (Math.Pow(i, 2) + 1) / (Math.Pow(i, 3) + 3);

                sum += term;

            }

            return sum;

        }

        public static double Task2First10()

        {

            int n = 10;

            double sum = 0;

            for (int i = 1; i < n + 1; i++)

            {

                sum += Math.Pow(-1, i) * (Math.Pow(i, 2) + 1) / (Math.Pow(i, 3) + 3);

            }

            return sum;

        }

        public static void Main(string[] args)

        {

            int n = 10000; // maximum number of iterations

            double eps = 1e-6; // desired precision

            Console.WriteLine($"Sum with precision {eps}: {Task2(n, eps)}");

            Console.WriteLine($"Sum of the first 10 terms: {Task2First10()}");

        }

    }

}
