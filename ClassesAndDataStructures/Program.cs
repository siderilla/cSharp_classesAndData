using System.Collections;

namespace ClassesAndDataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("pippo", "de pippis", "male", 2000);
            Student student2 = new Student("paperoga", "de paperoni", 2000);

            Student student3 = new("paperino", "de paperoni", 2000);

            var student4 = new Student("paperino", "de paperoni", 2000);

            Teacher teacher1 = new Teacher{Name = "pico",Surname = "de paperis",Suject = "math"};
            var teacher2 = new Teacher{ Name = "archimede", Surname = "pitagorico"};
            var teacher3 = new Teacher{ Name = "zapotec" };

            Student[] students = new Student[3];

            students[0] = student1;
            Student[] newArray = (Student[])students.Append(student2);
            students[2] = student3;
            Student[] newArray2 = AppendToStudentsArray(students, student4);


            ArrayList studentArrayList = new ArrayList();
            studentArrayList.Add(student1);
            studentArrayList.Add(student2);
            studentArrayList.Add(student3);
            studentArrayList.Add(student4);
            studentArrayList.Add(teacher1);


            List<Student> studentList = new List<Student>();
            studentList.Add(student1);
            studentList.Add(student2);
            studentList.Add(student3);
            studentList.Add(student4);


            Hashtable studentHashTable = new Hashtable();
            studentHashTable.Add("pippo", student1);
            studentHashTable.Add("pico", teacher1);
            studentHashTable.Add(5, teacher3);


            Dictionary<string, Student> studentDictionary = new Dictionary<string, Student>();
            studentDictionary.Add("pippo", student1);
            //studentDictionary.Add("pico", teacher1);
            //studentDictionary.Add(3, student2);

            SuperList<Student> superList = new SuperList<Student>();
            superList.Push(student1);
            superList.Push(student2);
            //superList.Push(teacher1);

            Student student = superList.Get(0);
            Student poppedStudent = superList.Pop();


        }

        static Student[] AppendToStudentsArray(Student[] originalArray, Student newStudent)
        {
            var originialLenght = originalArray.Length;
            var newArray = new Student[originialLenght + 1];
            for (int i = 0; i < originialLenght; i++)
            {
                newArray[i] = originalArray[i];
            }
            newArray[originialLenght] = newStudent;

            return newArray;
        }
    }
}
