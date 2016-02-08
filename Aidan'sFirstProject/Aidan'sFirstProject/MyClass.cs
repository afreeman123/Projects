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
        //private 
        string Name;

        //constructor
        public MyClass(string name)
        {
            Name = name;
        }

        //method
        public string name()
        {
            return Name;
        }

        public static void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
