using System;
using System.Collections.Generic;
using System.Text;

namespace School_Database
{
    class Group
    {
        public string ID;
        public string name_of_teacher;
        public List<Student> students;
        public Group(string _id, string name)
        {
            ID = _id;
            name_of_teacher = name;
            students = new List<Student>();
        }

        public double Get_average_grade()
        {
            double sum = 0;
            foreach (Student student in students)
                sum += student.Grades;
            return sum / students.Count;
        }

        public void Print_info()
        {
            Console.WriteLine("Class: " + ID);
            Console.WriteLine("Teacher: " + name_of_teacher);
            Console.WriteLine("Number of Students: " + students.Count);
            Console.WriteLine();
        }
        public void Print_by_grades()
        {
            int len = students.Count;
            for(int i = 1; i < len; i++)
            {
                Student key = students[i];
                int j = i - 1;
                while(j >= 0 && students[j].Grades > key.Grades)
                {
                    students[j+1] = students[j];
                    j--;
                }
                students[j + 1] = key;
            }
            Console.WriteLine("Sorted by grades: ");
            foreach (Student student in students)
                Console.WriteLine(student.name + " " + student.surname + " " + student.Grades);
            Console.WriteLine();
        }

        private static int CmpStudents(Student st1, Student st2)
        {
            if (st1.name != st2.name)
                return String.Compare(st1.name, st2.name);
            else
                return String.Compare(st1.surname, st2.surname);
        }
        public void Print_by_names()
        {
            int len = students.Count;
            for (int i = 1; i < len; i++)
            {
                Student key = students[i];
                int j = i - 1;
                while (j >= 0 && CmpStudents(students[j], key) > 0)
                {
                    students[j + 1] = students[j];
                    j--;
                }
                students[j + 1] = key;
            }
            Console.WriteLine("Sorted by name: ");
            foreach (Student student in students)
                Console.WriteLine(student.name + " " + student.surname + " " + student.Grades);
            Console.WriteLine();
        }
    }
}
