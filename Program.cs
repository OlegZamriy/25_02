using _25_02;

class Program
{
    static void Main()
    {
        int start = 1;
        int end = 5;

        int product = MathUtils.GetProductInRange(start, end);
        Console.WriteLine($"Добуток чисел від {start} до {end} дорівнює {product}");
    }
}
