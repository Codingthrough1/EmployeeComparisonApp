using System;

namespace EmployeeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the first Employee object and assign values
            Employee employee1 = new Employee();
            employee1.Id = 101;
            employee1.FirstName = "Alice";
            employee1.LastName = "Johnson";

            // Create the second Employee object and assign values
            Employee employee2 = new Employee();
            employee2.Id = 101; // Same Id as employee1 for testing equality
            employee2.FirstName = "Bob";
            employee2.LastName = "Smith";

            // Compare the two Employee objects using the overloaded == operator
            bool areEqual = employee1 == employee2;

            // Display the comparison result
            Console.WriteLine("Comparing Employee 1 and Employee 2...");
            Console.WriteLine($"Are they equal? {areEqual}");

            Console.ReadLine(); // Pause console so output can be read
        }
    }
}
