using System;

namespace StringOfSums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to String of Sums\n");

            SumParser sumParser = new SumParser();

            string sum = "2+4";
            Console.WriteLine($"{sum} = {sumParser.SolveSum(sum)}");

            sum = "17+21";
            Console.WriteLine($"{sum} = {sumParser.SolveSum(sum)}");

            sum = "88+12";
            Console.WriteLine($"{sum} = {sumParser.SolveSum(sum)}");

            sum = "66+23";
            Console.WriteLine($"{sum} = {sumParser.SolveSum(sum)}");
        }
    }
}
