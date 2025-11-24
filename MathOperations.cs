using System;

namespace MethodAssignment
{
    // Create a class called MathOperations
    public class MathOperations
    {
        // Create a void method that takes 2 integers
        public void DoMath(int num1, int num2)
        {
            // Perform a math operation (example: multiply num1 by 2)
            int result = num1 * 2;

            // Display result of the math
            Console.WriteLine("First number multiplied by 2 is: " + result);

            // Display the second integer
            Console.WriteLine("Second number is: " + num2);
        }
    }
}
