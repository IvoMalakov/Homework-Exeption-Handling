using System;
using System.Collections.Generic;

public class EnterNumbers
{
    private static int ReadNumber(int start, int end)
    {
        try
        {
            if (end <= start)
            {
                throw new ArgumentOutOfRangeException();
            }

            int number = int.MinValue;

            while (number < start || number > end)
            {
                Console.WriteLine("Enter a number in range from [{0}] to [{1}]", start, end);
                number = int.Parse(Console.ReadLine());

                if (number < start || number > end)
                {
                    throw new ArgumentOutOfRangeException();
                }

                else
                {
                    return number;
                }
            }

        }

        catch (NullReferenceException)
        {
            Console.WriteLine("Invalid number: Enter your number again: ");
        }

        catch (FormatException)
        {
            Console.WriteLine("Invalid number: Enter your number again: ");
        }

        catch (OverflowException)
        {
            Console.WriteLine("Invalid number: Enter your number again: ");
        }

        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid number: Enter your number again:");
        }

        return int.MaxValue;
    }

    public static void Main()
    {
        List<int> numberList = new List<int>();

        int start = 1;
        int end = 100;

        for (int i = 0; i < 10; i++)
        {
            int number = ReadNumber(start, end);

            if (number != int.MaxValue)
            {
                numberList.Add(number);
            }
        }

        Console.WriteLine("Your valid numbers are: {0}", String.Join(", ", numberList));
    }
}
