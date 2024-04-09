using _25_02;
using System;

class Program
{
    static void Main()
    {
        int number = 13;  

        bool result = MathUtils.IsFibonacciAndPrime(number);

        Console.WriteLine($"Число {number} є числом Фібоначчі та простим: {result}");
    }
}
