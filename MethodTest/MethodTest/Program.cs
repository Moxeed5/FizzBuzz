// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace C32Methodsdemo;

internal class Methods
{
    public int Max()
    {
        Console.WriteLine("Enter a number for x");
        int x = Console.ReadLine();
        Console.WriteLine("Enter a number for y");
        int y = Console.ReadLine();
        if (x > y)
            return x;

        else
            return y;

    }
    
    Methods.Max();
}