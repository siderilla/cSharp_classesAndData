using System.Collections;
using static System.Net.Mime.MediaTypeNames;

namespace ClassesAndDataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("pippo", "de pippis", "male", 2000, [1, 4, 6]);
            Student student2 = new ("paperoga", "de paperoni", "neutral", 1996, [6, 5, 7]);
            var student3 = new Student("paperino", "de paperoni", "bau", 1993, []);
            //var non è come let in JS → non è un tipo generico
            //il tipo rimane forte e fisso una volta assegnato
            //quindi var student4 è uno Student a tutti gli effetti, esattamente come gli altri

            Teacher teacher1 = new Teacher("pico", "de paperis", "math");
            var teacher2 = new Teacher("archimede", "archimodus", "");
            var teacher3 = new Teacher( "zapotec" );

            Student[] students = new Student[3];

            students[0] = student1;

            //Student[] newArray = (Student[])students.Append(student2); <--- non funziona, Append non restituisce un array ma un IEnumerable
            Student[] newArray = students.Append(student2).ToArray(); //IEnumerable è una sequenza iterabile, non un array, dunque va convertito in array con ToArray()

            students[2] = student3;
            Student[] newArray2 = AppendToStudentsArray(students, student3);


            ArrayList studentArrayList = new ArrayList();
            studentArrayList.Add(student1);
            studentArrayList.Add(student2);
            studentArrayList.Add(student3);
            studentArrayList.Add(teacher1);


            List<Student> studentList = new List<Student>();
            studentList.Add(student1);
            studentList.Add(student2);
            studentList.Add(student3);


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

            

            Console.WriteLine("Avvio OK");
            Console.WriteLine(student1.Name);
            Console.WriteLine(teacher1.Name);

            //testo getage e getavarage

            Console.WriteLine(student1.GetAge());
            Console.WriteLine(student2.GetAge());
            Console.WriteLine(student1.GetAverage());
            Console.WriteLine(student2.GetAverage());

            //testo l'aggiunta di student a teacher

            teacher1.AddStudent(student1);
            teacher1.AddStudent(student2);

            //stampo tutti gli studenti assegnati a teacher

            teacher1.PrintStudents();


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
