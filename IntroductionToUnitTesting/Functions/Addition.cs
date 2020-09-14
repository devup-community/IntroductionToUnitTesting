using System;

namespace IntroductionToUnitTesting.Functions
{
    public class Addition
    {
        public static void AddNumbers()
        {
            var consoleWriter = new ConsoleOutput();

            Console.Clear();
            Console.WriteLine("Adding numbers");

            var num1 = int.Parse(consoleWriter.CaptureInput("first"));
            var num2 = int.Parse(consoleWriter.CaptureInput("second"));

            var result = AddTwoNumbers(num1, num2);

            consoleWriter.DisplayResult(result);
        }

        public static int AddTwoNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
