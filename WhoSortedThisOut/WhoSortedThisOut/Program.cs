using System;

namespace WhoSortedThisOut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Who Sorted this Out\n");

            ArrayHelper helper = new ArrayHelper();

            int[] values = { 1, 15, 22, -3, 8, 0 };
            int[] otherValues = { 1021, 234, 33, -123, 1, 43 };
            int[] empty = { };

            Console.WriteLine($"Largest number in values @ index: {helper.Maximum(values)}");
            Console.WriteLine($"Largest number in otherValues @ index: {helper.Maximum(otherValues)}");
            Console.WriteLine($"Largest number in empty @ index: {helper.Maximum(empty)}");


            int[] first = { 1, 15, 22, 101, 2345, 12353 };
            int[] second = { 1021, 234, 33, -123, 1, 43 };
            int[] third = { -5, 4, 23, 55, 0 };
            Console.WriteLine($"Is first sorted ascending?: {helper.IsSortedAscending(first)}");
            Console.WriteLine($"Is second sorted ascending?: {helper.IsSortedAscending(second)}");
            Console.WriteLine($"Is third sorted ascending?: {helper.IsSortedAscending(third)}");
            Console.WriteLine($"Is empty sorted ascending?: {helper.IsSortedAscending(empty)}");
        }
    }
}
