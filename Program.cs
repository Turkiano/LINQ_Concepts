using System;
namespace Lambda_Expression;


public class Program
{
	delegate bool IsYoungerThan(Student stud, int youngAge);

	public static void Main()
	{
		//this is the lambda expression with 2 parameters
		IsYoungerThan isYoungerThan = (s, youngAge) =>
		{
			//statement 01.
			Console.WriteLine("Lambda expression with multiple statements in the body");

			//statement 02.
			return s.Age < youngAge;
		};
		//data source/ student object
		Student stud = new Student() { Age = 25 };
		//delegate executation
		Console.WriteLine(isYoungerThan(stud, 26));

	}
}