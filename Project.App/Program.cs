using System;
using static Project.Code.Operations;

namespace Project.App
{
    class Program
    {
        static void Main(string[] args)
        {
             while (!MainMenu()); //run until correct operation selected
            
        }

        static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("====  STUDENT APP 2000  ====");
            Console.WriteLine("Operations:");
            Console.WriteLine("E -> ENLIST (allows to insert student into list)");
            Console.WriteLine("D -> DISPLAY (displays list of students)");
            Console.WriteLine("X -> EXIT (i'm done here)");
            Console.Write("type your choice: ");

            return (CheckOperations(Console.ReadLine()));
            
        }
    }
}
