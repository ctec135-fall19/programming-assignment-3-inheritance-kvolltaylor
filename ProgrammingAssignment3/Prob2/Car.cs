﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    // Base Class -- Car
    class Car
    {

        #region fields

        // declare private string 
        private string carPrivateString;

        // declare protected string
        protected string carProtectedString;

        #endregion

        #region constructors

        // default constructor
        public Car () { }

        // master constructor
        public Car (string PrivateString, string ProtectedString)
        {
            // using chaining

            // initializing instance variables
            this.carPrivateString = PrivateString;
            this.carProtectedString = ProtectedString;

        }

        #endregion

        #region methods

        // CarMethod
        public void CarMethod()
        {
            Console.WriteLine("Car.CarMethod");
        }

        // PrintState Method
        // virtual means that the children and grandchildren methods
        // may override it
        public virtual void PrintState()
        {
            Console.WriteLine("Base: Car object");
            Console.WriteLine("\t- carPrivateString: {0}", carPrivateString);
            Console.WriteLine("\t- carProtectedString: {0}", carProtectedString);
        }

        #endregion

    }
}