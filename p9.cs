using System;

class Program
{
    static void Print1(int n)
    {
        for (int i = 1; i <=n; i++)
        {
            for (int j = 0; j <n-i-1; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j <2*i-1; j++)
            {
                Console.Write("*");
            }
            for (int j = 0; j <n-i-1; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
    static void Print2(int n)
    {
        for (int i = 1; i <=n; i++)
        {
            for (int j = 0; j <i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j <2*n-(2*i+1); j++)
            {
                Console.Write("*");
            }
            for (int j = 0; j <i; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < t; i++)
        {
            int n = int.Parse(Console.ReadLine());
            Print1(n);
            Print2(n);
        }
    }
}