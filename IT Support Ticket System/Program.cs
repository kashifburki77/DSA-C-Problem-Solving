using System;
using System.Collections.Generic;

public class program

{
    public static void Main(string[] args)
    {

        Console.WriteLine("Welcome to IT Support Team");
        Console.WriteLine("");

        PriorityQueue<string, int> Ticketpriority = new PriorityQueue<string, int>();
        Console.WriteLine("");


        Ticketpriority.Enqueue("Password Rest Issue", 4);
        Ticketpriority.Enqueue("Website Running Slowly", 3);
        Ticketpriority.Enqueue("Email Delivery Failure", 2);
        Ticketpriority.Enqueue("Broken Company Logo", 5);
        Ticketpriority.Enqueue("Checkout System Not Working", 1);
        Ticketpriority.Enqueue("Database Server Down", 6);


        while (Ticketpriority.Count > 0)
        {
            string result1 = Ticketpriority.Peek();
            Console.WriteLine("The Ticket With the Highest Priority is " + Ticketpriority.Peek());
            Console.WriteLine("The Ticket Problem is Processing and Our Team is Start Working on it " + Ticketpriority.Dequeue());
            Console.WriteLine(result1);
            Console.WriteLine("");

            string result2 = Ticketpriority.Peek();
            Console.WriteLine("The Ticket With the Highest Priority is " + Ticketpriority.Peek());
            Console.WriteLine("The Ticket Problem is Processing and Our Team is Start Working on it " + Ticketpriority.Dequeue());
            Console.WriteLine(result2);
            Console.WriteLine("");

            string result3 = Ticketpriority.Peek();
            Console.WriteLine("The Ticket With the Highest Priority is " + Ticketpriority.Peek());
            Console.WriteLine("The Ticket Problem is Processing and Our Team is Start Working on it " + Ticketpriority.Dequeue());
            Console.WriteLine(result3);
            Console.WriteLine("");

            string result4 = Ticketpriority.Peek();
            Console.WriteLine("The Ticket With the Highest Priority is " + Ticketpriority.Peek());
            Console.WriteLine("The Ticket Problem is Processing and Our Team is Start Working on it " + Ticketpriority.Dequeue());
            Console.WriteLine(result4);
            Console.WriteLine("");

            string result5 = Ticketpriority.Peek();
            Console.WriteLine("The Ticket With the Highest Priority is " + Ticketpriority.Peek());
            Console.WriteLine("The Ticket Problem is Processing and Our Team is Start Working on it " + Ticketpriority.Dequeue());
            Console.WriteLine(result5);
            Console.WriteLine("");

            string result6 = Ticketpriority.Peek();
            Console.WriteLine("The Ticket With the Highest Priority is " + Ticketpriority.Peek());
            Console.WriteLine("The Ticket Problem is Processing and Our Team is Start Working on it " + Ticketpriority.Dequeue());
            Console.WriteLine(result6);
            Console.WriteLine("");

        }


     }

   }
