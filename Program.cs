using System;

namespace Lambda_Expression;

					
public class Program
{
	delegate bool IsTeenAger(Student stud);
	
	public static void Main()
	{
		IsTeenAger isTeenAger = delegate(Student s) { return s.Age > 12 && s.Age < 20; };
		
		Student stud = new Student() { Age = 25 };
		
		Console.WriteLine(isTeenAger(stud));
		
		
	}
}