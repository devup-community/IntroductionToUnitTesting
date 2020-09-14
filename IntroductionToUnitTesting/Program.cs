using IntroductionToUnitTesting.Functions;
using System;

namespace IntroductionToUnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Introduction to Unit Testing");
            Console.WriteLine("We will be running a simple calculator");
            Console.WriteLine("Enter an option:");
            Console.WriteLine("1) Addition");
            Console.WriteLine("2) Subtraction");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Addition.AddNumbers();
                    return true;
                case "2":
                    Console.WriteLine("No exist yet");
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }
    }
}
