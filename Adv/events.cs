using System;
using System.Collections.Generic;

namespace enventHandling1
{
    //declareing a delegate type for the event 
    public delegate void DelEneventHandler();
    class Program
    {
        public static event DelEneventHandler add;

        static void Nepal()
        {
            Console.WriteLine("Nepal");
        
        }
        static void india()
        {
            Console.WriteLine("india");

        }
        static void china()
        {
            Console.WriteLine("china");

        }
        static void Main (string[] args)
        {
            add += new DelEneventHandler(Nepal);
            add += new DelEneventHandler(india);
            add += new DelEneventHandler(china);
            add.Invoke();
            Console.ReadKey();
        }



    }

}