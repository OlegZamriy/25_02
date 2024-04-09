using _25_02;
using System;

class Program
{
    static void Main()
    {
        int[] originalArray = { 1, 2, 6, -1, 88, 7, 6 };
        int[] filterArray = { 6, 88, 7 };

        int[] resultArray = ArrayFilter.FilterArray(originalArray, filterArray);

        Console.WriteLine("Результат фільтрації:");
        foreach (int item in resultArray)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
