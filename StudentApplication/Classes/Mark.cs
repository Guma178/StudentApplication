using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication.Classes
{
    public class Mark
    {
        private string nameOfSubject;
        private byte mark;

        public byte GetMark
        {
            get { return mark; }
            set { mark = value; }
        }
        public string GetNameOfSubject
        {
            get { return nameOfSubject; }
            set { nameOfSubject = value; }
        }

        public Mark(string nameOfSubject, byte mark)
        {
            this.mark = mark;
            this.nameOfSubject = nameOfSubject;
        }

        public static void GetMarksMassive(out Mark[] marks1)
        {
            Mark[] marks;
            Console.WriteLine("Enter count of marks");
            marks = new Mark[Convert.ToInt32(Console.ReadLine())];
            int i = 0;
            while ( i < marks.GetLength(0))
            {
                Console.WriteLine("Enter name of a mark and value of a mark");
                marks[i] = new Mark(Console.ReadLine(), Convert.ToByte(Console.ReadLine()));
                i++;
            }
            marks1 = marks;
        }
    }
}
