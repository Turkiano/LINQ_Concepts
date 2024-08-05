﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Student[] studentArray = {
            new Student() { StudentID = 1, StudentName = "John", Age = 18 },
            new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 },
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 },
            new Student() { StudentID = 4, StudentName = "Ram", Age = 20 },
            new Student() { StudentID = 5, StudentName = "Ron", Age = 31 },
            new Student() { StudentID = 6, StudentName = "Chris", Age = 17 },
            new Student() { StudentID = 7, StudentName = "Rob", Age = 19 },
        };

        Student[] students = StudentExtension.Where(studentArray, delegate (Student std)
        {
            return std.Age > 12 && std.Age < 20;
        });

        foreach (var student in students)
        {
            if (student != null)
            {
                Console.WriteLine($"{student.StudentName}, {student.Age}");
            }
        }
    }
}
