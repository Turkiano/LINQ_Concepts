using System;
					
public class Program
{
	delegate void Print();
	
	public static void Main()
	{
		Print print = () => Console.WriteLine("This is parameter less lambda expression");
		
		print();		
		
	}
}
