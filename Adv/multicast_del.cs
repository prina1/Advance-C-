// using System;
// using System.Collections.Generic;

// namespace multicast
// {
//     public delegate void SampleDelegate(); //global scope not recommanded 
//     public delegate void NewDelegate();

//     namespace MukticastDelegate
//     {
//         class Program
//         {
//             static void Main(string [] args)
//             {
//                 //sampleDelegate del = new SampleDelagate (sampleMethodOnne);
//                 //to creat emulticat dlegate is a delagate that points to more than one function

//                 SampleDelegate del1, del2, del3, del4;
//                 //now lets assign each delegate a method as 
//                 del1 = new SampleDelegate(SampleMethodOne);
//                 del2 = new SampleDelegate(SampleMethodTwo);
//                 del3 = new SampleDelegate(SampleMethodThree);
//                 del4 = del1 + del2 + del3;
//                 del4();


//                 NewDelegate Nd = new NewDelegate(NewMethodOne);
//                 Nd += NewMethodTwo;
//                 Nd += NewMethodThree;
//                 Nd();


//             }
//             public static void SampleMethodOne()
//             {
//                 Console.WriteLine("SampleMethodOne Invoked");
//             }
//             public static void SampleMethodTwo()
//             {
//                 Console.WriteLine("SampleMethodTwo Invoked");
//             }
//             public static void SampleMethodThree()
//             {
//                 Console.WriteLine("SampleMethodThree Invoked");
//             }
//             public static void NewMethodOne()
//             {
//                 Console.WriteLine("NewMethodOne Invoked");
//             }
//             public static void NewMethodTwo()
//             {
//                 Console.WriteLine("NewMethodTwo Invoked");
//             }
//             public static void NewMethodThree()
//             {
//                 Console.WriteLine("NewMethodThree Invoked");
//             }
//         }
//     }
// }
