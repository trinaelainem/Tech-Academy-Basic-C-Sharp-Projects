using System;

// Interface
interface IQuittable
{
    // Method signature for quitting
    void Quit();
}

// Employee class implementing the IQuittable interface
class Employee : IQuittable
{
    // Implementation of the Quit method from the interface
    public void Quit()
    {
        Console.WriteLine("Employee has quit the job.");
    }
}

// Example class demonstrating polymorphism with IQuittable
class PolymorphismExample
{
    // Method showcasing polymorphism
    public static void UsePolymorphism()
    {
        // Creating an object of type IQuittable, initialized with an Employee instance
        IQuittable quittableEmployee = new Employee();
        
        // Calling the Quit method on the IQuittable reference (polymorphism in action)
        quittableEmployee.Quit();
    }
}

// Main program class
class Program
{
    // Main method - entry point of the program
    static void Main()
    {
        // Invoking the UsePolymorphism method to demonstrate polymorphism
        PolymorphismExample.UsePolymorphism();
    }
}
