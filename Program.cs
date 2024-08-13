using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        // Sample list of integers
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Use Where with a predicate that checks if the number is even
        IEnumerable<int> evenNumbers = numbers.Where(n => n % 2 == 0);

        Console.WriteLine("Even numbers:"); //console header

        //Executation
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }
    }
}