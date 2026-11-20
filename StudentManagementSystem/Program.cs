using System;
using System.Collections;
using System.Collections.Generic;

public class program
{
    public static void Main(string[] args)
    {
        ArrayList students = new ArrayList();

        students.Add("Ali");
        students.Add("Ahmed");
        students.Add("Sohail");
        students.Add("Hanif");
        students.Add("AyunKhan");
        students.Add("KamranKhan");
        students.Add("Rahim");

        foreach(string student in students)
        {
            Console.WriteLine(students);
        }
    }
}