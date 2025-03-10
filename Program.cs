using System;
using MySql.Data.MySqlClient;

namespace StudentManagementSystem
{
    class StduentDashboard
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("1.Add Student\n2.View Student \n3.Search Student\n4.exit\nchoice : ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;

                        default:
                            Console.WriteLine("Invalid input try again!\n");
                            continue;
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine("Invalid input try again!\n");
                }
            }
        }
    }


    class Student
    {
        private String studentName;
        private int age;
        private String course;
        private char sex;
        private String studentId;

        public String StudentName//properties
        {
            get { return studentName; }
            set { studentName = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public String Course
        {
            get { return course; }
            set { course = value; }
        }
        public char Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        public String StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }
    }

}