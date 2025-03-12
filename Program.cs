using DotNetEnv;
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
                            Database database = new Database();
                            database.connectToDatabase(); //this will create the connection to the database
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

    class Database : Student
    {
        public void connectToDatabase()
        {
            //since the file .env is in the parent directory and not in the program.cs folder i use .. to move one folder to parent directory
            Env.Load("../../.env");
            String DB_HOST = Env.GetString("DB_HOST");
            String DB_USER = Env.GetString("DB_USER");
            String DB_PASSWORD = Env.GetString("DB_PASSWORD");
            String DB_NAME = Env.GetString("DB_NAME");


            String connectStr = $"server={DB_HOST}; database={DB_NAME}; user={DB_USER}; password={DB_PASSWORD}";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectStr))
                {
                    conn.Open(); //will try to contact the database connection 
                    Console.WriteLine("the connection was established successfully"); //if the connection was successfull this will print
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("An error occured while connecting to the database");
            }
        }

    }

}