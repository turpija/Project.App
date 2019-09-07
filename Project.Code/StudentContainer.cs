using System;
using System.Collections.Generic;

namespace Project.Code
{
    class StudentContainer
    {
        public static List<Student> studentList = new List<Student>();

        public static void AddStudent(Student student)
        {
            student.id = GenerateOIB();
            studentList.Add(student);

            Console.WriteLine("Adding student : firstName: {0} | lastName: {1} | GPA: {2} | ID: {3}",
                studentList[0].firstName,
                studentList[0].lastName,
                studentList[0].GPA,
                studentList[0].id
                );
            Console.WriteLine("press <ENTER> to continue ...");
            Console.ReadLine();
        }

        static string GenerateOIB()
        {
            //Console.WriteLine("GENEREATOROAIADSFODIF");
            var num = "";
            var random = new Random();
            for (int i = 0; i < 10; i++)
                num = String.Concat(num, random.Next(10).ToString());

            int a = 10;
            for (int i = 0; i < 10; i++)
            {
                a = a + Convert.ToInt32(num.Substring(i, 1));
                a = a % 10;
                if (a == 0) a = 10;
                a *= 2;
                a = a % 11;
            }
            int kontrolni = (11 - a);
            return num + Convert.ToString(kontrolni);
        }

    }
}
