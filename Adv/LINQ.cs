using System;
using Microsoft.VisualBasic;

class Program{
    static void Main()
    {
        List<int> numbers = new List<int>{1,2,3,4,5,6,7,8,9,10};

        //a la,da expression in a LINQ query to filter even numbers 

        var evennumbers = numbers.Where(num=>num%2==0);

        foreach (var number in evennumbers)
        {
            Console.WriteLine(number);
        }
    }
}