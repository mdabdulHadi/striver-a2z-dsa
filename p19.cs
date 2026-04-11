using System;

class Program
{
    static void Print(int n)
    {
        int initialSpace=0;
        for (int i = 1; i <=n; i++)
        {
            for (int j = 1; i <=n-i-1; j++)
            {
                Console.Write("*");
            }
            for(int j=0; j<initialSpace;j++){
                Console.Write(" ");

            }
            for (int j = 1; i <=n-i-1; j++)
            {
                Console.Write("*");
            }
            initialSpace+=2;
            Console.WriteLine();
        }
        int initialSpace=2*n-2;
        for (int i = 1; i <=n; i++)
        {
            for (int j = 1; i <=n-i-1; j++)
            {
                Console.Write("*");
            }
            for(int j=0; j<initialSpace;j++){
                Console.Write(" ");

            }
            for (int j = 1; i <=n-i-1; j++)
            {
                Console.Write("*");
            }
            initialSpace-=2;
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