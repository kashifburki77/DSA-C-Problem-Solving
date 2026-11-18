using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {

        PriorityQueue<string, int> patientprority = new PriorityQueue<string, int>();

        patientprority.Enqueue("Ahsan", 2);
        patientprority.Enqueue("Ali", 3);
        patientprority.Enqueue("Ahmed", 1);
        patientprority.Enqueue("Adeel", 4);
        patientprority.Enqueue("Awais", 6);
        patientprority.Enqueue("Asad", 5);
        patientprority.Enqueue("Ammar", 7);
        patientprority.Enqueue("Abdullah", 8);
        patientprority.Enqueue("Rahim", 10);
        patientprority.Enqueue("Rashid", 9);
        patientprority.Enqueue("Raza", 12);
        patientprority.Enqueue("Fatma", 11);
        patientprority.Enqueue("Hina", 13);
        patientprority.Enqueue("Haris", 14);
        patientprority.Enqueue("Hassan", 15);
        patientprority.Enqueue("Hafsa", 16);


        Console.WriteLine("The Patient with the Highest Priority is " + patientprority.Peek());

        Console.WriteLine("Patient Treatment Order is: ");

        while (patientprority.Count > 0)
        {
            Console.WriteLine(patientprority.Dequeue());
        }


    }
}
