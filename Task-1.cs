using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the lower bound (ki): ");
        int ki = int.Parse(Console.ReadLine());

        Console.Write("Enter the upper bound (k₂): ");
        int k2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"Perfect numbers in the range [{ki}, {k2}]:");

        for (int i = ki; i <= k2; i++)
        {
            if (IsPerfectNumber(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    static bool IsPerfectNumber(int num)
    {
        int sum = 1; // 1 is always a divisor, start with sum = 1

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                sum += i;

                // If the divisors are not the same, add the other divisor
                if (i != num / i)
                {
                    sum += num / i;
                }
            }
        }

        return sum == num;
    }
}
