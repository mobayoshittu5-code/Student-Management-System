using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace Practice
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public int SeatNumber { get; set; }
        public int Level { get; set; }
        public double GPA { get; set; }
        public Student (string name, int age, string address, string gender, int seatNumber, int level, double gpa)
        {
            Name = name;
            Age = age;
            Address = address;
            Gender = gender;
            SeatNumber = seatNumber;
            Level = level;
            GPA = gpa;
        }
        public static void DisplayStudent(Student student)
        {
            Console.WriteLine("Check Complete!");
            Console.WriteLine("===================================");
            Console.WriteLine("The following are your Details:\n");
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Age: {student.Age}");
            Console.WriteLine($"Address: {student.Address}");
            Console.WriteLine($"Sex: {student.Gender}");
            Console.WriteLine($"SeatNumber: Seat-00{student.SeatNumber}");
            Console.WriteLine($"Level: {student.Level}-Level");
            Console.WriteLine($"CGPA: {student.GPA}");
            Console.WriteLine("===================================");

            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string schoolMasterPass = "1234ABC";

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            
            bool enrolled = false;
            while (enrolled == false)
            {
                Console.Write("Are you Enrolled(Yes/No): ");
                string answer = Console.ReadLine();
                if (answer.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                {
                    enrolled = true;
                    break;
                }
                else if (answer.Equals("No", StringComparison.OrdinalIgnoreCase))
                {
                    enrolled = false;
                    Console.WriteLine("You are not a Student of this school!");

                }
                else
                {
                    Console.WriteLine("Please enter Yes or No!");
                }
                Console.WriteLine();
            }
            

            Student[] students =
            {
                new Student("Mobayo", 26, "32 Adebiaye St", "Male", 001, 300, 3.74),
                new Student("Felix", 21, "12 Gbemi Ogundeyi St", "Male", 002, 300, 3.20),
                new Student("James", 24, "05 Adeleke St", "Male", 003, 300, 2.90),
                new Student("Lilian", 24, "121 Paiko St", "Female", 004, 300, 3.11),
                new Student("Janet", 27, "04 Ifo St", "Female", 005, 300, 2.10)
            };


            Student foundStudent = null;
            if (enrolled == true)
            {
                Console.WriteLine("Checking...");
                foreach (Student student in students )
                {
                    if (name.Equals(student.Name, StringComparison.OrdinalIgnoreCase))
                    {
                        foundStudent = student;
                        string passInput = "";
                        while (!string.Equals(passInput,schoolMasterPass,StringComparison.OrdinalIgnoreCase))
                        {
                            Console.Write("Enter ID: ");
                            passInput = Console.ReadLine();
                            Console.WriteLine();
                            if (passInput.Equals( schoolMasterPass, StringComparison.OrdinalIgnoreCase))
                            {
                                Student.DisplayStudent(student);
                            }
                        }
                    }
                }
            }


                Console.ReadLine();
        }
        
    }
    

}
