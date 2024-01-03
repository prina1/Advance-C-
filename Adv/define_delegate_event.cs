using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

namespace Event 
{
    //defining a delegate type for the event
    public delegate void EventHandlerDelegate(object sender, EventArgs e);
    //class that contains the event
    public class Evenetpublisher{
        //declare the event using the delegate
        public event EventHandlerDelegate myEvent;
    
    public void TriggerEvent()
    {
        Console.WriteLine("Event Triggered");
        //check if there are any subscribers to the event
        if(myEvent != null)
        {
            EventArgs e = new EventArgs();
            
            //invoke the event, notifying subscribers
            myEvent(this, EventArgs.Empty);
        }
    }
       


    }
    public class Eventsubscirber
    {
        //method that handles the event
    public void HandleEvent(object sender, EventArgs e )
    {
        Console.WriteLine("Event Handled by Eventsubscirber");
    }
}



class Program
{
    static void Main()
    {
        //create instances of the publisher and subscriber 
        Evenetpublisher publisher  = new Evenetpublisher();
        Eventsubscirber subscriber = new Eventsubscirber();

        //subscribe the subscriber to the publisher event
        publisher.myEvent += new EventHandlerDelegate(subscriber.HandleEvent); 

        //trigger the event
        publisher.TriggerEvent();
        
        //unsubscribe the subscriber from the publisher event
        publisher .myEvent -= subscriber.HandleEvent; 

        //trigger the event again no subscribers
        publisher.TriggerEvent();

    }
}
}