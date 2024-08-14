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
        
        // Retrieve and print the first element of intList
        Console.WriteLine("01.1st Element in intList: {0}", intList.First());
        
        // Retrieve and print the first even element of intList
        Console.WriteLine("02.1st Even Element in intList: {0}", intList.First(i => i % 2 == 0));
        
        // Retrieve and print the first element of strList
        Console.WriteLine("03.1st Element in strList: {0}", strList.First());

        // Note in the code: emptyList.First() will throw an InvalidOperationException
        Console.WriteLine("04.emptyList.First() throws an InvalidOperationException");
        Console.WriteLine("-------------------------------------------------------------");
        
        // Attempt to retrieve the first element of an empty list (this will cause an exception)
        Console.WriteLine(emptyList.First());
    }
}
