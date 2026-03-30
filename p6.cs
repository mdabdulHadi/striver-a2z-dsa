using System;

class Program
{
    static void Print(int n)
    {
        for (int i = 1; i <=n; i++)
        {
            for (int j = 0; j <=n-i+1; j++)
            {
                Console.Write(j+ " ");
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
            Print(n);
        }
    }
}