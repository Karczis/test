// See https://aka.ms/new-console-template for more information

using System; 
namespace probleme
{
    class Program
    {
        static void Main()
        {

            // Reading the first number
            Console.Write("Enter the first number: ");
            double a = Convert.ToDouble(Console.ReadLine());

            // Reading the second number
            Console.Write("Enter the second number: ");
            double b = Convert.ToDouble(Console.ReadLine());

            // Performing arithmetic operations
            double sum = a + b;
            double difference = a - b;
            double product = a * b;
            double quotient = b != 0 ? a / b : double.NaN; // Handling division by zero

            // Displaying the results
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);
        }
    }


}
    
