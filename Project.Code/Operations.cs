using System;
using System.Collections.Generic;
using System.Text;
using static Project.Code.Enlist;
using static Project.Code.Display;


namespace Project.Code
{
    public class Operations
    {
        public static bool CheckOperations(string userInput)
        {
            while (true)
            {
                if ("ENLIST".Equals(userInput, StringComparison.OrdinalIgnoreCase)
                    || "E".Equals(userInput, StringComparison.OrdinalIgnoreCase))
                {
                    EnlistStudent();
                    return false;
                }
                else if ("DISPLAY".Equals(userInput, StringComparison.OrdinalIgnoreCase)
                    || "D".Equals(userInput, StringComparison.OrdinalIgnoreCase))
                {
                    DisplayStudents();
                    return false;
                }
                else if ("exit".Equals(userInput, StringComparison.OrdinalIgnoreCase)
                    || "x".Equals(userInput, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("exiting...");
                    return true;
                }
                else
                {
                    Console.WriteLine("! operation not found !");
                    Console.WriteLine("press <ENTER> to continue ...");
                    Console.ReadLine();
                    return false;
                }
            }


        }

    }
}
