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
        private int intNumber;
        private string strProduce;

        public Class1(int Number, string Produce)
        {
            intNumber = Number;
            strProduce = Produce;
        }
        #endregion

        #region methods
        // create methods for both fields' accessors and mutators
        public int Number
        {
            get { return intNumber; }
            set { intNumber = value; }
        }
        public string Produce
        {
            get { return strProduce; }
            set { strProduce = value; }
        }
        #endregion

        #region nested classes : IComparer

        // nested classes to use for sorting both fields
        // using IComparer to create multiple methods for sorting

        // nested class for sorting strings in strProduce field in alphabetic order
        public class sortProduceDescendingHelper : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Class1 obj1 = (Class1)a;
                Class1 obj2 = (Class1)b;
                return String.Compare(obj2.strProduce, obj1.strProduce);
            }
        }

        // nested class for sorting ints in intNumber field in descending order
        public class sortNumberDescendingHelper : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Class1 obj1 = (Class1)a;
                Class1 obj2 = (Class1)b;
                if (obj1.intNumber < obj2.intNumber)
                    return 1;
                if (obj1.intNumber > obj2.intNumber)
                    return -1;
                else
                    return 0;

            }
        }
        #endregion

        #region methods for IComparable use 
        // Implement IComparable CompareTo to provide default sort order.
        int IComparable.CompareTo(object obj)
        {
            Class1 compare = (Class1)obj;
            return String.Compare(this.Produce, compare.Produce);
        }

        //Method to return IComparer object for sort helper.
        public static IComparer sortProduceDescending()
        {
            return (IComparer)new sortProduceDescendingHelper();
        }

        //Method to return IComparer object for sort helper.
        public static IComparer sortNumberDescending()
        {
            return (IComparer)new sortNumberDescendingHelper();
        }

        

        #endregion

    }
}
