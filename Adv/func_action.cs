using System;
using System.Collections.Generic;
// class Program{
//     static void Main()
//     {
//     Func<int, int, int> addFunc = (a, b) => a + b;
//     int result = addFunc(5,3);
//     Console.WriteLine(result);
//     }

// }


//Action delegate 
class Program{
    static void Main()
    {
        //Example using action delegate
        Action<string> greetAction = (name) =>
        Console.WriteLine($"Hello, {name}!");
        greetAction("World");
        

    }
}

