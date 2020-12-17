using System;

namespace SeriousProgress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Serious Progress\n");

            ConsoleHelper progress = new ConsoleHelper();

            Console.WriteLine(progress.GenerateProgressBar(0, 20));
            Console.WriteLine(progress.GenerateProgressBar(1, 20));
            Console.WriteLine(progress.GenerateProgressBar(5, 20));
            Console.WriteLine(progress.GenerateProgressBar(9, 20));
            Console.WriteLine(progress.GenerateProgressBar(14, 20));
            Console.WriteLine(progress.GenerateProgressBar(18, 20));
            Console.WriteLine(progress.GenerateProgressBar(20, 20));

        }
    }
}
