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
        string myString;

        //constructor
        public MyClass(string name)
        {
            myString = name;
        }

        //property Name
        public string Name
        {
            get { return myString; }
            set
            {
                if (value == "")
                {
                    MessageBox.Show("You can't do that");
                }
            }
        }

       
    }
}
