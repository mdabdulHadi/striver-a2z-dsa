using System;

class Program
{
    static void Print(int n)
    {
        for (int i = 0; i <n; i++)
        {
            for (int j = 0; j <n; j++)
            {
                if(i==0||j==0||i==n-1||j==n-1){
                Console.Write("*");
                }
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