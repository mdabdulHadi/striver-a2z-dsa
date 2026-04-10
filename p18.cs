using System;

class Program
{
    static void Print(int n)
    {
        for (int i = 0; i <n; i++)
        {
            for (char ch='E'-i;; ch <='E'; ch++)
            {
                Console.Write(ch+" ");
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