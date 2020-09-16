using System;

namespace IntroductionToUnitTesting.Functions
{
    public static class Subtraction
    {
        public static void SubtractNumbers()
        {
            var consoleWriter = new ConsoleOutput();

            Console.Clear();
            Console.WriteLine("Subtracting numbers");

            var num1 = double.Parse(consoleWriter.CaptureInput("first"));
            var num2 = double.Parse(consoleWriter.CaptureInput("second"));

            var result = SubtractTwoNumbers(num1, num2);

            consoleWriter.DisplayResult(result);
        }

        public static double SubtractTwoNumbers(double num1, double num2)
        {
            return num1 - num2;
        }
    }
}
