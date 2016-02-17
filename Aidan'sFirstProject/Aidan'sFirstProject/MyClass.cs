using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNamespace
{
    class MyClass
    {
        //has to be static as method is static
        static Exception emptyString = new Exception("You can't set this string equal to an Empty String");

        public static void CheckString(string myString)
        {
            if (myString == "") throw emptyString;
        }
       
    }
}
