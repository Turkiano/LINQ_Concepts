using System;

namespace Delegate_Example;
					
public class Program
{
	delegate bool IsTeenAger(Student stud); //Delegate property with boolean data type
	
	public static void Main()
	{
	//delegate condition
		IsTeenAger isTeenAger = delegate(Student s) { return s.Age > 12 && s.Age < 20; };
		
		Student stud = new Student() { Age = 25 }; //data source or student object
		
		//delegat Executation
		Console.WriteLine(isTeenAger(stud));
		
		
	}
}