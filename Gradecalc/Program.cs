﻿using System;

public class Grade
{
    public static void Main()
    {
        int marks;
        Console.Write("Enter marks: ");
        marks = int.Parse(Console.ReadLine());
        if (marks >= 90)
        {
            Console.WriteLine("Grade A+");
        }
        else if (marks >= 80)
        {
            Console.WriteLine("Grade A");
        }
        else if (marks >= 70)
        {
            Console.WriteLine("Grade B");
        }
        else if (marks >= 60)
        {
            Console.WriteLine("Grade C");
        }
        else if (marks >= 50)
        {
            Console.WriteLine("Grade D");
        }
        else
        {
            Console.WriteLine("Grade F");
        }
    }
}