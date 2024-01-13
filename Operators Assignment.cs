using System;

// Employee class
class Employee
{
    // Properties of Employee Class
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overload the "==" operator
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // Check if both are null, considered equal
        if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
        {
            return true;
        }
        // Check if only one is null, considered not equal
        else if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
        {
            return false;
        }

        // Compare the Id property for equality
        return emp1.Id == emp2.Id;
    }

    // Overload the "!=" operator
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        // Inverse of the equality operator
        return !(emp1 == emp2);
    }

    // Override Equals method for better comparison
    public override bool Equals(object obj)
    {
        // Check for null and type mismatch
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        // Cast the object to Employee for comparison
        Employee otherEmployee = (Employee)obj;
        return Id == otherEmployee.Id;
    }

    // Override GetHashCode to provide a unique hash code
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}

class Program
{
    static void Main()
    {
        // Instantiate two Employee objects with their values
        Employee employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
        Employee employee2 = new Employee { Id = 0, FirstName = "Jane", LastName = "Doe" };

        // Compare the two Employee objects using the overloaded "=="
        bool areEqual = employee1 == employee2;

        // Display the results
        Console.WriteLine($"Employees are equal: {areEqual}");
    }
}
