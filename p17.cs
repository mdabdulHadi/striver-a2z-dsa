using System;

class Program
{
    static void Print(int n)
    {
        for (int i = 1; i <=n; i++)
        {
            for (int j = 0; j <n-i-1; j++)
            {
                Console.Write(" ");
            }
            char ch='A';
            int breakpoint=(2*i+1)/2;
            for (int j = 0; j <=2*i+1; j++)
            {
                Console.Write(ch);
                if(j<-breakpoint)
                ch++;
                else ch--;
            }
            for (int j = 0; j <n-i-1; j++)
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
            Print(n);
        }
    }
}