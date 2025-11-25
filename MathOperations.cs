using System;

namespace EmployeeComparison
{
    // Employee class representing a simple employee record
    public class Employee
    {
        public int Id { get; set; }               // Employee ID
        public string FirstName { get; set; }     // First name of the employee
        public string LastName { get; set; }      // Last name of the employee

        // Overload the == operator to compare Employee objects by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both are null, they are equal
            if (ReferenceEquals(emp1, emp2))
                return true;

            // If one is null but not the other, they are not equal
            if (emp1 is null || emp2 is null)
                return false;

            // Compare using employee Id
            return emp1.Id == emp2.Id;
        }

        // Overload the != operator (must be paired with ==)
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2); // Reuse the logic of ==
        }

        // Override Equals to match the operator overloads
        public override bool Equals(object obj)
        {
            if (obj is Employee emp)
                return this.Id == emp.Id;

            return false;
        }

        // Override GetHashCode whenever Equals is overridden
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
