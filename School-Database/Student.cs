using System;
using System.Collections.Generic;
using System.Text;

namespace School_Database
{
    class Student
    {
        public string name;
        public string surname;
        private double grades;
        public Student(string _name, string _surname, int _grades)
        {
            name = _name;
            surname = _surname;
            Grades = _grades;
        }
        public double Grades
        {
            get { return grades; }
            set {
                if (value >= 2.0 && value <= 6.0)
                    grades = value;
                else 
                    grades = 6.0;   
                }
        }
    }
}
