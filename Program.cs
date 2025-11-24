using System;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class
            MathOperations math = new MathOperations();

            // Call the method normally
            math.DoMath(5, 10);

            // Call the method using named parameters
            math.DoMath(num2: 20, num1: 8);

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
