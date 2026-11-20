using System;
using System.Collections.Generic;

public class program
{
    public static void Main(string[]args)
    {
        LinkedList<string> students = new LinkedList<string>();

        students.AddLast("Ahtasham");
        students.AddLast("Ali");       
        students.AddLast("Rahim");
        students.AddLast("Zeeshan");
        students.AddLast("Ahsan");
        students.AddLast("Zia");
        students.AddLast("Sohail");
        students.AddLast("Noman");
        students.AddLast("Ayub");
        students.AddLast("Salman");

        Console.WriteLine(students.First());
        Console.WriteLine(students.Last());
       

    }

} 
