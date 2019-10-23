using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob5
{
    public class Class1 : IComparable
    {
        #region fields
        // create 2 fields for use with this class
        private int intQuantity;
        private string strProduce;

        // create properties to access to those fields
        //accessors and mutators
        public int IntQuantity 
        { 
            get {return intQuantity;} 
            set {intQuantity = value;}
        }
        public string StrProduce
        { 
            get {return strProduce;} 
            set {strProduce = value;}
        }
        #endregion

        #region constructors

        // create constructors for members
        public Class1(string produce, int quantity)
        {
            this.intQuantity = quantity;
            this.strProduce = produce;
        }
        #endregion

        #region methods
        // create interface method for making comparisons in order to sort them

        // sort by first sifting by alphabetic order of string, 
        // then sifting by the numeric value of int
        public int CompareTo(object obj) 
        {
            // cast obj object type to Class1 type
            // using implicit casting with "as" operator
            // implicit casting: 
            // Class1 castObj = obj as Class1;
            // explicit casting:
            Class1 castObj = (Class1)obj;


            // check first to make sure casting to Class1 worked
            if (castObj != null)
            {
                // compare strings and return a value based on that comparison
                if (String.Compare(this.StrProduce, castObj.StrProduce) < 0) return -1;
                if (String.Compare(this.StrProduce, castObj.StrProduce) > 0) return 1;
                // if the strings are the same, then move on to compare next field of ints
                // compare ints and return a value based on that comparison
                else 
                {
                    if(this.IntQuantity < castObj.IntQuantity) return -1;
                    if (this.IntQuantity > castObj.IntQuantity) return 1;
                    else return 0;
                }

            }
            // throw up an exception if the previous casting of object type to
            // Class1 type did not result in a Class1 type object
            else throw new ArgumentException ("Error: parameter not a Class1 object");

        }
         // override ToString so can print object
        public override string ToString()
        {
            // string interpolation using special character $
            // return $"{StrProduce}, {IntQuantity}";
            // this can also be written as:
            return StrProduce + ", " + IntQuantity;
        }
        #endregion

      

    }
}
