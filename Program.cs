using System;
					
public class Program
{
	delegate void Print(); // 01. Delegate Declaration
	
	public static void Main()
	{
		// 02. Lambda Expression Assignment
		Print print = () => Console.WriteLine("This is parameter less lambda expression");
		
		print(); // 03. Delegate Invocation
		
	}
}
