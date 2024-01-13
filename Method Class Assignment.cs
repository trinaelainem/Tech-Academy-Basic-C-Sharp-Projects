using System;

// Class with a void method
public class MathOperation
{
    // Void method taking two integers as parameters
    public void PerformOperation(int firstNumber, int secondNumber)
    {
        // Perform a math operation on the first integer
        int result = firstNumber * 2;

        // Display the second integer to the screen
        Console.WriteLine($"The result of the math operation on {firstNumber} is: {result}");
    }
}

class Program
{
    static void Main()
    {
        // Instantiate the MathOperation class
        MathOperation mathOperation = new MathOperation();

        // Call the method in the class, passing in two numbers (5 and 10)
        mathOperation.PerformOperation(5, 10);

        // Call the method in the class, specifying the parameters by name (8 and 15)
        mathOperation.PerformOperation(firstNumber: 8, secondNumber: 15);
    }
}
