using _25_02;
using System;

class Program
{
    static void Main()
    {
        int num1 = 1221;
        int num2 = 3443;
        int num3 = 7854;

        Console.WriteLine($"{num1} - паліндром? {PalindromeChecker.IsPalindrome(num1)}");
        Console.WriteLine($"{num2} - паліндром? {PalindromeChecker.IsPalindrome(num2)}");
        Console.WriteLine($"{num3} - паліндром? {PalindromeChecker.IsPalindrome(num3)}");
    }
}
