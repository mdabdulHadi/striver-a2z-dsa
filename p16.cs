using System;

class Program
{
    static void Print(int n)
    {
        for (int i = 0; i <n; i++)
        {
            char ch='A'+i;
            for (int j = 0; j <=i; j++)
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