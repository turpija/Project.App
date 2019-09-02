using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using static Project.Code.Student;

namespace Project.Code
{


    class Enlist
    {

        //static Student student = new Student();

        public static void EnlistStudent()
        {
            var student = new Student();

            Console.WriteLine("------------->  ENLIST  <-------------");
            FirstName(student);
            LastName(student);
            GPA(student);
            StudentContainer.AddStudent(student);
        }

        private static void FirstName(Student student)
        {

            while (true)
            {
                Console.Write("  First name: ");

                var userInput = Console.ReadLine();

                if (userInput == "")
                {
                    Console.WriteLine("!! you need to actually write something !!");
                }
                else if (!Regex.IsMatch(userInput, @"^[a-zA-Z]*$"))
                {
                    Console.WriteLine("!! real last name this time ...just letters please !!");
                }
                else
                {
                    student.firstName = userInput;
                    break;
                }
            }


        }

        private static void LastName(Student student)
        {
            while (true)
            {
                Console.Write("  Last name: ");
                var userInput = Console.ReadLine();

                if (userInput == "")
                {
                    Console.WriteLine("!! you need to actually write something !!");
                }
                else if (!Regex.IsMatch(userInput, @"^[a-zA-Z]*$"))
                {
                    Console.WriteLine("!! real last name this time ...just letters please !!");
                }
                else
                {
                    student.lastName = userInput;
                    break;
                }
            }
        }

        private static void GPA(Student student)
        {
            while (true)
            {
                Console.Write("  GPA: ");
                var userInput = Console.ReadLine();
                double result = 0;

                if (userInput == "")
                {
                    Console.WriteLine("!! you need to actually write something !!");
                }
                else
                {
                    try
                    {
                        result = Convert.ToDouble(userInput.Replace(".", ","));
                        if (result >= 1 && result <= 5)
                        {
                            //Console.WriteLine(result);
                            student.GPA = result;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("!! GPA is not in valid range (1.0-5.0)!!");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("!! not a valid number !!");
                    }
                }

            }
        }


    }
}
