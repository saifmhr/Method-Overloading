using System;
using System.ComponentModel;

public class Program
    {
     public  static void Main()
        {
        Add(20, 30);
        Add(10, 20, 10);
        }

    public static void Add(int FN, int LN)
    {
        Console.WriteLine("Sum = {0} ", FN + LN);
    }

    public static void Add(int FN, int LN,int TN)
    {
        Console.WriteLine("Sum = {0} ", FN + LN + TN);
    }

}
