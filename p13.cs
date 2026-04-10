using System;

class Program
{
    static void Print(int n)
    {
        int num=1;
        for (int i = 1; i <=n; i++)
        {
            for (int j = 1; j <=i; j++)
            {
                Console.Write(num + " ");
            }
            for (int j = 1; j <=space; j++)
            {
                Console.Write(" ");
            }
            for (int j = i; j >=1; j--)
            {
                Console.Write(j);
            }
            Console.WriteLine();
            space-=2;
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