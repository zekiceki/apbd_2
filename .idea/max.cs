using System;

public class Calculator
{
    public static int FindMax(int[] numbers)
    {
        if (numbers.Length == 0)
        {
            throw new ArgumentException("Array must not be empty");
        }

        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        return max;
    }

    public static void Main(string[] args)
    {
        int[] numbers = { 1, 5, 3, 7, 2 };
        Console.WriteLine("Maximum value: " + FindMax(numbers));
    }
}