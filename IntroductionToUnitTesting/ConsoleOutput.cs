using System;

namespace IntroductionToUnitTesting
{
    public class ConsoleOutput
    {
        public string CaptureInput(string number)
        {
            Console.Write($"Enter the {number} you want to add: ");
            return Console.ReadLine();
        }

        public void DisplayResult(int result)
        {
            Console.WriteLine($"\r\nResult of the two numbers is: {result}");
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }
    }
}
