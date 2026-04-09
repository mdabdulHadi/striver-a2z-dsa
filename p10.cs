using System;

class Program
{
    static void Print(int n)
    {
        for (int i = 1; i <=2*n-1; i++)
        {
            int stars=i;
            if(i>n)
            stars=2*n-i;
            for (int j = 1; j <stars; j++)
            {
                Console.Write("* ");
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