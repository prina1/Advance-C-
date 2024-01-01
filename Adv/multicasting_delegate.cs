// using System;
// using System.Collections.Generic;

// delegate int NumberChanger(int n);
// class Testdelegate{
//     static int num = 10;

//     public static int AddNum(int p)
//     {
//         num+= p;
//         return num;
//     }
//     public static int MulNum(int q)
//     {
//         num*= q;
//         return num;
//     }
//     public static int getNum()
//     {
//         return num;
//     }
//     static void Main(string[]args)
//     {
//         // creating delegate instances
//         NumberChanger nc;
//         NumberChanger nc1 = new NumberChanger(AddNum);
//         NumberChanger nc2 = new NumberChanger(MulNum);
//         nc = nc1;
//         nc += nc2;

//         //calling multicast 
//         nc(5);
//         Console.WriteLine("Value of Num: {0}", getNum());
//         Console.ReadKey();

//     }

// }