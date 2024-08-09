using System;

namespace Lambda_Expression;


public class Program
{
	//Delegate Declaration with two parameters (student object, and int type)
	delegate bool IsTeenAgerThan(Student stud, int youngAge);

	public static void Main()
	{
		//local variable with delegate type assigned to lambda expression
		IsTeenAgerThan isYoungerThan = (s, youngAge) => s.Age < youngAge;

		Student stud = new Student() { Age = 25 };  //student object


		//calling the delegate local variable (object, int argument)
		Console.WriteLine(isYoungerThan(stud, 26));


	}
}
		//the output is true since 25 is less than 26