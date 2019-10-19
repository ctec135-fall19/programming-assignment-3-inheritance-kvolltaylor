using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    // Child Class -- Make is a child of Car
    class Make : Car
    {

        #region fields

        // declare protected string
        protected string makeProtectedString;
        private string makePrivateString;

        #endregion

        #region constructors

        // default constructor
        public Make () { }

        // master constructor
        public Make(string makeProtectedString, string makePrivateString, 
            string carPrivateString, string carProtectedString)

            // using chaining

            // using the keyword base
            // these two are inherited constructors from the base class of car
            : base(carPrivateString, carProtectedString)

        {

            // initializing instance variables
            this.makeProtectedString = makeProtectedString;
            this.makePrivateString = makePrivateString;

        }


        #endregion

        #region methods

        // MakeMethod
        public void MakeMethod()
        {
            Console.WriteLine("Make.MakeMethod");
        }

        // PrintState Method
        // override means that the method in the child class of 
        // Make will override the virtual PrintState method in the base class
        public override void PrintState()
        {

            Console.WriteLine("Child : Make object");
            Console.WriteLine("\t- makeProtectedString: {0}", makeProtectedString);
            Console.WriteLine("\t- makePrivateString: {0}", makePrivateString);
            base.PrintState();

        }

        #endregion

    }
}
