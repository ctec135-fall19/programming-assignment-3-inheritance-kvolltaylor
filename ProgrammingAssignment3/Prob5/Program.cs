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

            // Input: an array of objects with 2 fields, one an int & on a string
            // Process: submit objects to their class' interface method to sort
            // Output: display objects sorted by alphabetic, then numberic field values
            
            // Create an array of objects of Class1 type
            // pass values as parameters into each field for each object
            Class1[] objects = new Class1[10];
            objects[0] = new Class1 ("banana", 42 );
            objects[1] = new Class1 ("banana", 40 );
            objects[2] = new Class1 ("banana", 10 );
            objects[3] = new Class1("endive", 5 );
            objects[4] = new Class1("apple", 24 );
            objects[5] = new Class1("carrot", 777 );
            objects[6] = new Class1("daikon", 124 );
            objects[7] = new Class1 ("banana", 492 );
            objects[8] = new Class1("endive", 53 );
            objects[9] = new Class1("carrot", 80 );

            // Display the array of objects unsorted
            Console.WriteLine("The array of objects unsorted:\n");
            foreach(Class1 obj in objects)
            {
                Console.WriteLine("\t" + obj);
            }
            Console.WriteLine();
            Console.WriteLine(new string('_', 30) + "\n\n");

            // Sort objects by fields first alphabetically, then numerically
            Array.Sort(objects);

             // Display the array of objects after sorting
            Console.WriteLine("The array of objects sorted:\n");
            foreach(Class1 obj in objects)
            {
                Console.WriteLine("\t" + obj);
            }
            Console.WriteLine();
            Console.WriteLine(new string('_', 30) + "\n\n");

        }
    }
}
