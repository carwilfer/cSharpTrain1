using System;
using System.Collections.Generic;

public static class NumberExtensions
{
    public static bool IsArmstrong(this int number)
    {
        int originalNumber = number;
        int sum = 0;
        int numDigits = originalNumber.ToString().Length;

        while (number > 0)
        {
            int digit = number % 10;
            sum += (int)Math.Pow(digit, numDigits);
            number /= 10;
        }

        return sum == originalNumber;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Números de Armstrong de 1 a 10000:");
        for (int i = 1; i <= 10000; i++)
        {
            if (i.IsArmstrong())
            {
                Console.WriteLine(i);
            }
        }
    }
}