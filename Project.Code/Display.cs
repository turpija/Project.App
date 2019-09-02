using System;
using System.Collections.Generic;
using System.Text;


namespace Project.Code
{
    class Display
    {
        public static void DisplayStudents()
        {
            Console.WriteLine("------------->  DISPLAY  <-------------");
            Console.WriteLine("Students in a system: {0}", StudentContainer.studentList.Count);
            displayStudents();
            Console.WriteLine("press <ENTER> to continue ...");
            Console.ReadLine();
        }

        static void displayStudents ()
        {
            for (int i = 0; i < StudentContainer.studentList.Count; i++)
            {
                var item = StudentContainer.studentList[i];
                Console.WriteLine("  {0}. {1}, {2} - {3}", i+1, item.lastName, item.firstName, item.GPA);

            }

            foreach (var item in StudentContainer.studentList)
            {
                
            }
        }
    }
}
