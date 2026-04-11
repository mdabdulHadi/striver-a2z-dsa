using System;

class Program
{
    static void Print(int n)
    {
        for (int i = 0; i <2*n-1; i++)
        {
            for (int j = 0; j <2*n-1; j++)
            {
                int top=i;
                int left=j;
                int right=(2*n-2)-j;
                int down=(2*n-2)-i;
                Console.Write(n-min(min(top, down), min(left, right)));  
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