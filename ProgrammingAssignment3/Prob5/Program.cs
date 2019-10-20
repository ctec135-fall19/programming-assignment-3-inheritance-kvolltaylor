/*

Author: Katrina Voll-Taylor
Team: Torin Tashima and Katrina Voll-Taylor
Date: 21 October 2019
CTEC 135: Microsoft Software Development with C#
Module 4, Programming Assignment 3, Problem 5

    Prob 5: 

        - Create a class with two fields, one a string and the other an int. 
          The class implements the IComparable interface.
        - Create appropriate methods for the class
        - Objects in the class should be ordered in the following manner:
            - primary sort order is alphabetical according to the text field
            - secondary sort order is largest first according to the int field
        - Demonstrate the the objects can be sorted according to requirement

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array of objects
            // pass values into each field using their set method
            Class1[] objects = new Class1[5];
            new Class1 (42, "banana" );
            new Class1(5, "endive" );
            new Class1(24, "apple" );
            new Class1(777, "carrot" );
            new Class1(124, "daikon" );

            // Display the array of objects unsorted
            Console.WriteLine("The array of objects unsorted:\n");
            foreach(Class1 obj in objects)
            {
                Console.Write(obj.Number);
                Console.WriteLine(" - " + obj.Produce);
            }
            Console.WriteLine();
            Console.WriteLine(new string('*', 55) + "\n\n");

            // Display the array of objects sorted by Number
            // Sorted by descending value
            
            // Display the array of objects sorted by Produce
            // Sorted by alphabetic order

        }
    }
}
