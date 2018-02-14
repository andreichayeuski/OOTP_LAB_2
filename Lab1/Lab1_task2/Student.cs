using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Lab1_task2
{
    public class Student : IComparable<Student>, IComparer<Student>
    {
        public short group;
        public short kurs;
        public string name;
        private string[] options_of_names = new string[10]
        {
            "Andrei", "Alena", "Yaroslav", "Bogdan", "Anna", "Anastasiya", "Maksim", "Vadim", "Polina", "Diana"
        };

        public Student()
        {
            Random random = new Random();
            Thread.Sleep(10); // хватит ли одного рандома?
            this.kurs = (short)random.Next(1, 5);
            this.group = (short)random.Next(1, 11);
            this.name = options_of_names[random.Next(0, 10)];
        }
        
        public int Compare(Student st1, Student st2)
        {
            return st2.CompareTo(st1);
        }

        public int CompareTo(Student student)
        {
            if (student == null)
            {
                return 1;
            }
            else
            {
                if (this.kurs > student.kurs)
                {
                    return 1;
                }
                else if (this.kurs < student.kurs)
                {
                    return -1;
                }
                else
                {
                    if (this.group > student.group)
                    {
                        return 1;
                    }
                    else if (this.group < student.group)
                    {
                        return -1;
                    }
                    else
                    {
                        return this.name.CompareTo(student.name);
                    }
                }
            }
        }
    }
}