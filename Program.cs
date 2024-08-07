using System;

namespace Lambda_Expression;

					
public class Program
{
	delegate bool IsTeenAger(Student stud); // delegate variable
	
	public static void Main()
	{
		IsTeenAger isTeenAger = s => s.Age > 12 && s.Age < 20; //lambda condition
		
		Student stud = new Student() { Age = 25 }; //data source
		
		Console.WriteLine(isTeenAger(stud));
		
		
	}
}