using System;
namespace Lambda_Expression;

					
public class Program
{
	delegate bool IsYoungerThan(Student stud, int youngAge);
	
	public static void Main()
	{
		IsYoungerThan isYoungerThan = (s, youngAge) => {
			
			
			return s.Age < youngAge;
		};
		
		Student stud = new Student() { Age = 25 };
		
		Console.WriteLine(isYoungerThan(stud, 26));
		
		}
	}