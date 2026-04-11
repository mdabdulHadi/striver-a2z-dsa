using System;

class Program
{
    static void Print(int n)
    {
        int spaces=2*n-2;
        for (int i = 1; i <=2*n-1; i++)
        {
            int stars=i;
            if(i>n) stars=2*n-i;
            for (int j = 1; j <=stars; j++)
            {
                Console.Write("*");
            }
            for(int j=1; j<=spaces;j++){
                Console.Write(" ");
            }
            for (int j = 1; i <stars; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            if(i<n) spaces-=2;
            else spaces+=2
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