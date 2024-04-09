using _25_02;
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть кількість рядків матриці: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Введіть кількість стовпців матриці: ");
        int cols = int.Parse(Console.ReadLine());

        Matrix matrix = new Matrix(rows, cols);

        matrix.InputMatrix();
        matrix.DisplayMatrix();

        int max = matrix.FindMax();
        int min = matrix.FindMin();

        Console.WriteLine("Максимум: " + max);
        Console.WriteLine("Мінімум: " + min);
    }
}
