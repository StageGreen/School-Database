using System;
using System.Collections.Generic;

namespace School_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] first_names = { "James", "Robert", "John", "Michael",
                "William", "David", "Richard", "Joseph",
                "Thomas", "Charles", "Mary", "Patricia",
                "Jennifer", "Linda", "Elizabeth", "Barbara",
                "Susan", "Jessica", "Sarah", "Karen"};

            string[] last_names = {"Smith","Johnson","Williams","Brown",
                "Jones", "Garcia", "Miller", "Davis",
                "Rodriguez","Martinez", "Hernandez", "Lopez",
                "Gonzalez", "Wilson", "Anderson", "Thomas",
                "Taylor", "Moore", "Jackson", "Martin"};

            //Example use of functions
            List<Group> groups = GenerateGroups(first_names, last_names);
            PrintGroupsInfo(groups);
            PrintGroupsGrades(groups);
            Console.WriteLine("----------------");
            groups[1].Print_by_grades();
            groups[1].Print_by_names();
        }

        static Group GenerateGroup( string [] first_names, string[] last_names, string ID)
        {
            Random rand = new Random();
            int size = 20 + rand.Next(10);
            string teacher = first_names[rand.Next(first_names.Length)] + " " + last_names[rand.Next(last_names.Length)];
            Group gr = new Group(ID, teacher);
            for(int i = 0; i < size; i++)
            {
                Student temp_student = new Student(first_names[rand.Next(first_names.Length)],
                    last_names[rand.Next(last_names.Length)], 2+rand.Next(5));
                gr.students.Add(temp_student);
            }
            return gr;
        }

        static List<Group> GenerateGroups(string[] first_names, string[] last_names)
        {
            string[] letters = { "A", "B", "V", "G", "D", "E" };
            Random rand = new Random();
            int count = 4 + rand.Next(3);
            int grade = rand.Next(13);
            List<Group> groups = new List<Group>();
            for (int i = 0; i < count; i++)
            {
                groups.Add(GenerateGroup(first_names, last_names, grade + letters[i]));
            }
            return groups;
        }

        static void PrintGroupsInfo(List<Group> groups)
        {
            foreach (Group group in groups)
                group.Print_info();
        }

        static void PrintGroupsGrades(List<Group> groups)
        {
            foreach (Group group in groups)
                Console.WriteLine(group.ID + " " + group.Get_average_grade());
        }
}
}
