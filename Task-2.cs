using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsPrime(number))
        {
            Console.WriteLine($"{number} is a prime number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a prime number.");
        }
    }

    static bool IsPrime(int num)
    {
        if (num <= 1)
        {
            return false; // 0 and 1 are not prime numbers
        }

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false; // If num is divisible by any number between 2 and its square root, it's not prime
            }
        }

        return true; // If no divisor is found, the number is prime
    }
}
