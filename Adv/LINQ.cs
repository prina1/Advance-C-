// using System;
// using Microsoft.VisualBasic;

// class Program{
//     static void Main()
//     {
//         List<int> numbers = new List<int>{1,2,3,4,5,6,7,8,9,10};

//         //a la,da expression in a LINQ query to filter even numbers 
//method syntax
//         var evennumbers = numbers.Where(num=>num%2==0);

//         foreach (var number in evennumbers)
//         {
//             Console.WriteLine(number);
//         }
//     }
// }
// using System;
// using System.Collections.Generic;
// using System.Linq;

// class LINQQueryExpressions
// {
//     static void Main()
//     {
//         //specify the data source
//         int[] scores = new int[] {97, 92, 81, 60};

//         //define the query expression
//         IEnumerable<int> scoreQuery = from score in scores 
//                                       where score > 80
//                                       select score;

//         //execute the query
//         foreach (int i in scoreQuery)
//         {
//             Console.WriteLine(i + " ");
//         }
//     }
// }
