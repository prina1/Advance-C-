using System;
using System.Collections.Generic;

delegate int MathOperation(int x, int y);

class MyClass
{
    public int Add(int x, int y)
    {
        return x + y;
    }
}

delegate void DisplayMessage(string message);

class Program
{
    //methods compatible with the delegate 
    static void ShowMessage(string message) => 
    Console.WriteLine(message);

    static void Main(string[] args)
    {
        DisplayMessage displayDelegate = new DisplayMessage(ShowMessage);
        displayDelegate("Hello, World!");
    }
}


