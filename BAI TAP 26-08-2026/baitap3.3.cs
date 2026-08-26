using System;

class Program
{
    static bool IsPrime(int n)
    {
        if (n < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    static bool IsPerfectNumber(int n)
    {
        if (n <= 1)
        {
            return false;
        }

        int sum = 0;

        for (int i = 1; i < n; i++)
        {
            if (n % i == 0)
            {
                sum = sum + i;
            }
        }

        return sum == n;
    }

    static void Main(string[] args)
    {
        Console.Write("Nhap so nguyen duong N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (IsPrime(n))
        {
            Console.WriteLine(n + " la so nguyen to");
        }
        else
        {
            Console.WriteLine(n + " KHONG la so nguyen to");
        }

        if (IsPerfectNumber(n))
        {
            Console.WriteLine(n + " la so hoan hao");
        }
        else
        {
            Console.WriteLine(n + " KHONG la so hoan hao");
        }

        Console.WriteLine("Day Fibonacci " + n + " so:");

        int a = 0;
        int b = 1;

        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");

            int next = a + b;
            a = b;
            b = next;
        }
    }
}