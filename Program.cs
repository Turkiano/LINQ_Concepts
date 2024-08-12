﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace Lambda_Expression;

					
public class Program
{
	public static void Main()
	{
		// Student collection
		IList<Student> studentList = new List<Student>() { 
				new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
				new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
				new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
				new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
				new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 } 
			};
		//Delegate assigned to lambda expression
		Func<Student, bool> isStudentTeenAger = s => s.Age > 12 && s.Age < 20;
		
		//LINQ Query Syntax = SQL
		var teenAgerStudents = from s in studentList
                   where isStudentTeenAger(s)
                   select s;
							  
		Console.WriteLine("Teen age Students:");
					
					//The executation of LINQ Query	  
		foreach(Student std in teenAgerStudents){			
			Console.WriteLine(std.StudentName);
		}
	}
}
/*
The output is the following
Teen age Students:
John
Bill
Ron 
*/