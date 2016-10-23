using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication.Classes
{
    public class Student
    {
        private DateTime birthday;
        private int id;
        private static int lastId = -1;
        private string name;
        private string patronymic;
        private string lastname;
        private Mark[] marks;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public Student(DateTime birthday, string name, string patronymic, string lastname, Mark[] marks)
        {
            this.birthday = birthday;
            this.name = name;
            this.patronymic = patronymic;
            this.lastname = lastname;
            this.marks = marks;
            lastId++;
            id = lastId;
        }

        public void GetAvgMark(out float ret)
        {
            float avgMark = 0f;
            for (int i = 0; i < marks.GetLength(0); i++)
                avgMark += marks[i].GetMark;
            ret =  avgMark / marks.GetLength(0);
        }

        public void ResetAllMarks()
        {
            int i = 0;
            while (i<marks.GetLength(0))
            {
                marks[i].GetMark = 0;
                i++;
            }
                
        }

        public void PrintInformation()
        {
            string marksString = "Marks:";
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Identifier: " + id);
            Console.WriteLine("Name: "+ name);
            Console.WriteLine("Patronymic: " + patronymic);
            Console.WriteLine("Lastname: " + lastname);
            Console.WriteLine("Birthday: " + birthday.ToString());
            for (int i = 0; i < marks.GetLength(0); i++)
                marksString += " Subject name: " + marks[i].GetNameOfSubject + " Value of a mark: " + marks[i].GetMark;
            Console.WriteLine(marksString);
            Console.WriteLine("---------------------------------------");
        }

        public static void GetStudentsMassive(out Student[] stud)
        {
            Student[] students;
            Mark[] marks;
            bool forw=true;
            Console.WriteLine("Enter count of students");
            students = new Student[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < students.GetLength(0); i++)
            {
                Console.WriteLine("Enter mark massive, birthday, name, patronymic, lastname");
                forw = true;
                for (; forw;)
                    try
                    {
                        Mark.GetMarksMassive(out marks);
                    students[i] = new Student(
                                                new DateTime(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())),
                                                Console.ReadLine(),
                                                Console.ReadLine(),
                                                Console.ReadLine(),
                                                marks
                                             );
                    forw = false;
                    }
                    catch
                    {
                        Console.WriteLine("You make some mistake. Try again");
                    }
            }
            stud = students;
        }
    }
}
