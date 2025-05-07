using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassesAndDataStructures
{
    internal class Student
    {
        public string Name { get; } // readonly property, can be set only in the constructor
        public string Surname { get; set; } // public property, can be set outside the class
        public string Gender { get; set; }

        private int _yob; // private field, can be set only in the constructor

        public int Yob
        {
            get => _yob;
            set
            {
                if (value < 1900)
                {
                    _yob = 1900;
                }
                else
                {
                    _yob = value;
                }
            }
        }

        public int[] Marks { get; set; } // public property, can be set outside the class

        public Student(string name, string surname, string gender, int yob, int[] marks)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
            Yob = yob;
            Marks = marks;
        }

        public double GetAverage()
        {
            if (Marks == null || Marks.Length == 0)
            {
                return 0;
            }
            return Marks.Average();
        }

        public int GetAge()
        {
            int currentYear = DateTime.Now.Year;
            return currentYear - _yob;
        }
    }
}
