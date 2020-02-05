using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Students
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Student (string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public override string ToString()
        {
            string a = $"{this.FirstName} {this.LastName}: {this.Grade:F2}";
            return a;
        }
    }
    class Program
    {
        static void Main()
        {
            int numberInput = int.Parse(Console.ReadLine());
            List<Student> studentsList = new List<Student>();
            for (int i = 0; i < numberInput; i++)
            {
                string[] studentInfo = Console.ReadLine().Split().ToArray();

                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                double grade = double.Parse(studentInfo[2]);

                Student newStudent = new Student(firstName, lastName, grade);
                studentsList.Add(newStudent);
            }

            studentsList = studentsList.OrderByDescending(x => x.Grade).ToList();
            for (int i = 0; i < numberInput; i++)
            {
                Console.WriteLine(studentsList[i].ToString());
            }
        }
    }
}
