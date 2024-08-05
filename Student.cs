using System;

class Student
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
}

delegate bool FindStudent(Student std);

class StudentExtension
{
    public static Student[] Where(Student[] stdArray, FindStudent del)
    {
        int i = 0;
        Student[] result = new Student[10];
        foreach (Student std in stdArray)
        {
            if (del(std))
            {
                result[i] = std;
                i++;
            }
        }
        return result;
    }
}
