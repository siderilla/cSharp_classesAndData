using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndDataStructures
{

    internal class Teacher
    {
        public string Name { get; set; }  //public required string vuole una sintassi diversa nel costruttore in main
        public string? Surname { get; set; }
        public string? Subject { get; set; }
        public List<Student> Students { get; set; } //dichiaro la proprietà

        public Teacher(string name, string? surname = null, string? subject = null)
        {
            Name = name;
            Surname = surname;
            Subject = subject;
            Students = new List<Student>(); //inizializzo nel costruttore
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }


        public void PrintStudents()
        {
            foreach (var student in Students)
            {
                Console.WriteLine($"{student.Name} {student.Surname}");
            }
        }
    }
}
