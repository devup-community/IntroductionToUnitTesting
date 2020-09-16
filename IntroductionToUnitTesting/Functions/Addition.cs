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

            var num1 = double.Parse(consoleWriter.CaptureInput("first"));
            var num2 = double.Parse(consoleWriter.CaptureInput("second"));

            var result = AddTwoNumbers(num1, num2);

            consoleWriter.DisplayResult(result);
        }

        public static double AddTwoNumbers(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}
