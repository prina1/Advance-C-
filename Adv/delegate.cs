//it know the how to call method 

using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
delegate int CalculatorDelegeate(int x, int y);

class Calculator 
{
    public static int Add(int x, int y)
    {
        return x+y;
    }
    public static int Subtract(int x , int y)
    {
        return x-y;
    }
    public static int Multiply(int x, int y)
    {
        return x*y;
    }
    public static int Divide(int x , int y)
    {
        if(y != 0)
        return x/y;
        else 
        throw new ArgumentException("cannot divide by zero");
    }
}
class Program
{
    static void Main()
    {
        //step 3 : creating instances of the delegate
        CalculatorDelegeate addDelegate = Calculator.Add;
        CalculatorDelegeate subtractDelegate = Calculator.Subtract;
        CalculatorDelegeate multiplyDelegate = Calculator.Multiply;
        CalculatorDelegeate divideDelegate = Calculator.Divide;

        //step 4  using the delegate to perform calculations
        int result1 = performCalculation(10,5,addDelegate);
        Console.WriteLine($"Addition Result:{result1}");

        int result2 = performCalculation(10,5,subtractDelegate);
        Console.WriteLine($"Subtraction Result:{result2}");

        int result3 = performCalculation(10,5, multiplyDelegate);
        Console.WriteLine($"Multiplication Result:{result3}");
        try{
            int result4 = performCalculation(10,0, divideDelegate);
        Console.WriteLine($"Division Result:{result4}");
        

        }
        catch(ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        static int performCalculation(int x, int y, CalculatorDelegeate calculator)
        {
            return calculator(x,y);
        }
        //step 6 invoking delegate 
        
        
    }

}