// we can use SQL 
//Familier C# language 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Student 
{
    public string Name { get; set; }
    public int Age {get; set;}
    public double Grade {get; set;}
}

class Program
{
    static void Main (string [] args)
    {
        List<Student> students = new List<Student> 
        {
            new Student {Name = "Ahmed", Age = 20, Grade = 90},
            new Student {Name = "Mohamed", Age = 22, Grade = 95},
            new Student {Name = "Ali", Age = 21, Grade = 85},
            new Student {Name = "Mahmoud", Age = 23, Grade = 80},
            new Student {Name = "Khaled", Age = 24, Grade = 75},
            new Student {Name  = "Imroj" , Age= 23, Grade=80}
        };
        //retrieve all students whose age is greater than 20 
        var studentsAbove20 = students.Where(s=>s.Age>20);

        //retrieve all students whose age is greater than 20 and grade is greater than 80
        var studentsAbove80 = students.Where(s=>s.Age>20 && s.Grade>80);

        //retrieve all students whose name starts with A
        var studentsStartsWithA = students.Where(s => s.Name.StartsWith("A")).Select(s => s.Name);

        //retrieve the average grade of all students 
        var averageGrade = students.Average(s=>s.Grade);

        //retrieve the student with the highest grade
        var highestGrade = students.OrderByDescending(s => s.Grade).FirstOrDefault();

        //print the results 
        Console.WriteLine("students above 20 years old ");
        foreach (var student in studentsAbove20)
        {
            Console.WriteLine(student.Name);
        }
        Console.WriteLine("students with grade above 80 ");
        foreach (var student in studentsAbove80)
        {
            Console.WriteLine(student.Name);
        }
        Console.WriteLine("students whose name starts with A ");
        foreach (var student in studentsStartsWithA)
        {
            Console.WriteLine(student);
        }
        Console.WriteLine("average grade of all students ");
        Console.WriteLine(averageGrade);
        Console.WriteLine("student with the highest grade ");
        Console.WriteLine(highestGrade.Name);
    }
}