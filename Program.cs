using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Initialize three lists with different types and values
        IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
        IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
        IList<string> emptyList = new List<string>();

        // Retrieve and print the first element of intList or the default value (0 for int)
        Console.WriteLine("01. 1st Element in intList: {0}", intList.FirstOrDefault());

        // Retrieve and print the first even element of intList or the default value if none exists
        Console.WriteLine("02. 1st Even Element in intList: {0}", intList.FirstOrDefault(i => i % 2 == 0));

        // Retrieve and print the first element of strList or the default value (null for string)
        Console.WriteLine("03. 1st Element in strList: {0}", strList.FirstOrDefault());

        // Attempt to retrieve the first element of an empty list (returns default value, null for string)
        Console.WriteLine("04. 1st Element in emptyList: {0}", emptyList.FirstOrDefault());
    }
}