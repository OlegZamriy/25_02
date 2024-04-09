using _25_02;
using System;

class Program
{
    static void Main()
    {
        int[] array = { 5, 2, 8, 1, 9 };

        Console.WriteLine("Оберіть напрям сортування:");
        Console.WriteLine("1. За зростанням");
        Console.WriteLine("2. За зменшенням");
        int choice = int.Parse(Console.ReadLine());

        bool ascending = (choice == 1) ? true : false;

        SortUtils.BubbleSort(array, ascending);

        Console.WriteLine("Відсортований масив:");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
