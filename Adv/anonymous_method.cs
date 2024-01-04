// //anonymous provides a technique to pass a code block as a degree parameter. it is using the delegate keyword. it is useful when you want to pass a method as an argument to another method. it is also useful to write a method that can be executed in another thread.
// //delegate coid NumberChanger (int n);
// using System;
// namespace AnnymousMethod
// {
//     class Program
//     {
//         //defining a delegate with the same signature as the anonymous method
//         delegate void myDelegate(string message);
//         static void Main()
//         {
//             //instaanting the delegate using anonymous method
//             myDelegate myDelegate = delegate (string msg)
//             {
//                 Console.WriteLine("Anonymous method: " + msg);
//             };
//             //calling the delegate
//             myDelegate("Hello World");

//             //using lambad expression
//             myDelegate myDelgate = (msg) => Console.WriteLine("Anonymous method: " + msg);
            
//             //calling delegate 
//             myDelgate("Hello World");

//         }

       
//         }
    
// }
   