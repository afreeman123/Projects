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
        //integer array that has representations of integers inside of it
        enum Names
        {
            Aidan = 1,
            Joe = 4,
            Bob //by default would equal 4
        }

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

        Names myName = Names.Aidan;

        public static void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        //can overload method as long as the parameters are different
        public static void ShowMessage(int message)
        {
            MessageBox.Show(message.ToString());
        }
    }
}
