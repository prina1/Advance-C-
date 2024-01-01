// using System;
// using System.Collections.Generic;

// namespace Delegate1
// {
//     delegate int NumberChanger(int n); // declare delegate

//     class Testdelegate
//     {
//         //declare a field 
//         static int num = 10;
//         //define a methid 
//         public static int AddNum(int p)
//         {
//             num += p;
//             return num;
//         }
//         public static int MulNum(int q)
//         {
//             num *= q;
//             return num;
//         }
//         public static int getNum()
//         {
//             return num;

//         }
//         static void Main(string [] args)
//         {
//             //create delegate instances 
//             NumberChanger nc1 = new NumberChanger(AddNum); // creating instance of a delesgate
//             NumberChanger nc3 = AddNum; // creating instance of a delegate
//             NumberChanger nc2 = new NumberChanger(MulNum);
//             //callling the methods using the delegate objects
//             //nc(5);
//             Console.WriteLine("Value of NUm : {0}", getNum());
//             nc2(5);
//             Console.WriteLine("value of Num : {0}", getNum());
//             nc3(5);

//             Console.WriteLine("Value of num by object nc3 is : {0}", getNum());


//         }
//     }
// }
