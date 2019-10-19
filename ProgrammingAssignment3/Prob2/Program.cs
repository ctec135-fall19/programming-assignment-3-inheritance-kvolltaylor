/*

Author: Katrina Voll-Taylor
Team: Torin Tashima and Katrina Voll-Taylor
Date: 21 October 2019
CTEC 135: Microsoft Software Development with C#
Module 4, Programming Assignment 3, Problem 2

    Prob 2: Demo of Field Access and Constructor Calling Sequence

        Create a class hierarchy that:
            - Demonstrates the effect of the private and protected access
            modifiers on access to fields from child classes.
            - Demonstrates the calling sequence of constructors.
            - Demonstrates setting and getting field values.

        Write-up should:
            - Explain how access modifiers constrain access to fields 
            by child classes. Is there an interaction with the abstract 
            class modifier? How does the use of properties affect access?
            - Explain your results on the constructor calling sequence demo
            - Do some research and find an example that justifies the use 
            of the protected keyword on a field.

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Car is the base class
            // Make is the child class

            #region demonstrate base class fields
            // PUBLIC ACCESS MODIFIER
            // Input:  new Car object, using public access modifier 
            // Process: passes value into field by acessing object
            // Output: prints value of that field
            Car carPublicFieldExample = new Car();
            Console.WriteLine("Passing field values into Car object directly:");
            Console.WriteLine(new string('_', 55) + "\n");
            carPublicFieldExample.carPublicString = "Honk!";
            Console.WriteLine("Base: Car object");
            Console.WriteLine("\t- carPublicString: {0}", 
                carPublicFieldExample.carPublicString);
            Console.WriteLine();

            // PRIVATE AND PROTECTED ACCESS MODIFIERS
            // Input:   new Car object, with 2 parameter values
            // Process: passes parameter values into method
            // Output:  prints values of those 2 fields

            // create new object for base class Car
            // pass parameter values to set fields using base master constructor
            Car carClass = new Car("Auto","Car");
            Console.WriteLine("Passing field values into Car master constructor:");
            Console.WriteLine(new string('_', 55) + "\n");
            carClass.PrintState();
            Console.WriteLine("\n");
            Console.WriteLine();

            #endregion

            Console.WriteLine(new string('*', 55) + "\n\n");

            #region demonstrate child class fields
            // Input:   new Make object, with 4 parameter values
            // Process: passes parameter values into method, with method 
            //          using method from base class to access those values
            // Output:  prints values of those 4 fields


            // create new object for child class Make
            // pass parameter values to set fields using child master constructor
            Make makeClass2 = new Make("Ford", "Volkswagen", "Vehicle","BeepBeep");
            Console.WriteLine("Passing field values into Make master constructor:");
            Console.WriteLine(new string('_', 55) + "\n");
            makeClass2.PrintState();
            Console.WriteLine("\n");

            #endregion

        }
    }
}
