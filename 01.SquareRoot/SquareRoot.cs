using System;

public class SquareRoot
{
    public static void Main()
    {     
        try
        {
            Console.WriteLine("Enter your number. Your number must be positive: ");
            string numberAsString = Console.ReadLine();
            int number = int.Parse(numberAsString);
            double squareRootNumber = CalculateSquareRoot(number);

            Console.WriteLine("The square root of your number {0} is {1:F2}", number, squareRootNumber);
        }

        catch (NullReferenceException)
        {
            Console.Error.WriteLine("Invalid number");
        }

        catch (FormatException)
        {
            Console.Error.WriteLine("Invalid number");
        }

        catch (OverflowException)
        {
            Console.Error.WriteLine("Invalid number");
        }

        catch (ArgumentOutOfRangeException)
        {
            Console.Error.WriteLine("Invalid number");
        }

        finally 
        {
            Console.WriteLine("Good bye");
        }
    }

    private static double CalculateSquareRoot(int number)
    {
        if (number < 0)
        {
            throw new System.ArgumentOutOfRangeException("Invalid number");
        }

        double squareRootNumber = Math.Sqrt(number);
        return squareRootNumber;
    }
}