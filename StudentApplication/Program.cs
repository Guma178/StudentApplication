using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentApplication.Classes.Student[] students = null;
            bool forw = true;
            int currentStudentID;
            byte choice;
            float avgMark;

            StudentApplication.Classes.Student.GetStudentsMassive(out students);

            foreach (StudentApplication.Classes.Student st in students)
                st.PrintInformation();

            while (forw)
            {
                Console.WriteLine("Make your choice:");
                Console.WriteLine("1. Average value of student marks");
                Console.WriteLine("2. Making all student’s marks equal to zero");
                Console.WriteLine("3. Print information about student");
                Console.WriteLine("0. Exit");
                choice = Convert.ToByte(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Enter ID of student");
                        currentStudentID = Convert.ToInt32(Console.ReadLine());
                        foreach (StudentApplication.Classes.Student st in students)
                            if (st.ID == currentStudentID)
                            {
                                st.GetAvgMark(out avgMark);
                                Console.WriteLine("Average value of marks belongs student with ID equal {0} is {1}", st.ID, avgMark);
                            }
                               
                        break;
                    case 2:
                        foreach (StudentApplication.Classes.Student st in students)
                            st.ResetAllMarks();
                        break;
                    case 3:
                        Console.WriteLine("Enter ID of student");
                        currentStudentID = Convert.ToInt32(Console.ReadLine());
                        foreach (StudentApplication.Classes.Student st in students)
                            if (st.ID == currentStudentID)
                                st.PrintInformation();
                    break; 
                    default:
                        forw = false;
                        break;
                }
            }

        }
    }
}
